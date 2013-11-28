using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using abmsgFB.dto;
using Abmsg.Logic;

namespace Abmsg.Controllers
{
    public class FacebookController : ApiController
    {
        public HttpResponseMessage Post(AccessToken accessToken)
        {
            FacebookManager.Instance.AccessToken = accessToken.value;
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
