using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Abmsg.Logic;
using AbmsgModel;
using AbmsgModel.Data;
using Abmsg.dto;
using System.Linq;

namespace Abmsg.Controllers
{
    public class NewsController : ApiControllerBase
    {

        public NewsController(IUow uow)
        {
            Uow = uow;
        }

        public HttpResponseMessage Post(NewsDto aNews)
        {
            Uow.News.Add(new AbmsgModel.Data.News(aNews.Title, aNews.Content));
            Uow.Commit();
            new NewsManager(aNews);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // GET api/news
        public IEnumerable<News> Get()
        {
            return Uow.News.GetAll().OrderByDescending(n => n.Date).Take(4);
        }

        public News Get(int id)
        {
            return Uow.News.GetById(id);
        }

        // Edit 

        // Delete

    }
}
