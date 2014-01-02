﻿using System.Collections.Generic;
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
            NewsManager mgr = new NewsManager(aNews,Uow);
            return (mgr.Apply() ?  Request.CreateResponse(HttpStatusCode.OK) :  Request.CreateResponse(HttpStatusCode.NotFound));
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

        // DELETE api/task/id where id is a int
        public HttpResponseMessage Delete(int id)
        {
            if (Uow.News.Delete(id))
            {
                Uow.Commit();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
