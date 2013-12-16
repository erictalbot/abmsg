using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Abmsg.dto;
using Abmsg.Logic;
using AbmsgModel;

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


        // Edit 

        // Delete

    }
}
