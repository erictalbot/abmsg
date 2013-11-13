using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using abmsgFB.dto;

namespace Abmsg.Controllers
{
    public class FacebookController : ApiController
    {
        public HttpResponseMessage Post(AccessToken accessToken)
        {
            string actk = accessToken.value;

            return Request.CreateResponse(HttpStatusCode.OK);

        }


        public IEnumerable<string> Get()
        {
            return new List<string>();

        }

    }
}
