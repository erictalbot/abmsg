using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Abmsg.dto;
using Abmsg.Logic;

namespace Abmsg.Controllers
{
    public class NewsController : ApiController
    {
        public HttpResponseMessage Post(ANews aNews)
        {
            new NewsManager(aNews);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
