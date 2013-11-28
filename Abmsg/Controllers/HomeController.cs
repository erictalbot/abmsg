using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AbmsgModel;
using AbmsgModel.Data;
using abmsgFB;

namespace Abmsg.Controllers
{
    public class HomeController : Controller
    {





        //public void g1()
        //{
        //    Facebook.FacebookClient fbClient = new Facebook.FacebookClient(GetAccessToken());

        //}

        //private string GetAccessToken()
        //{
        //    if (HttpRuntime.Cache["access_token"] == null)
        //    {
        //        Dictionary<string, string> args = GetOauthTokens(Request.Params["code"]);
        //        HttpRuntime.Cache.Insert("access_token", args["access_token"], null, DateTime.Now.AddMinutes(Convert.ToDouble(args["expires"])), TimeSpan.Zero);
        //    }

        //    return HttpRuntime.Cache["access_token"].ToString();
        //}

        //private Dictionary<string, string> GetOauthTokens(string code)
        //{
        //    Dictionary<string, string> tokens = new Dictionary<string, string>();

        //    string clientId = "xxxxxxxxxxxxxxxxxx";
        //    string redirectUrl = "http://localhost:51215/TestFBWebSite/FacebookRedirect.aspx";
        //    string clientSecret = "xxxxxxxxxxxxxxxxxxxxxx";

        //    string url = string.Format("https://graph.facebook.com/oauth/access_token?  client_id={0}&redirect_uri={1}&client_secret={2}&code={3}",
        //                    clientId, redirectUrl, clientSecret, code);
            

        //    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
        //    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        //    {
        //        StreamReader reader = new StreamReader(response.GetResponseStream());
        //        string retVal = reader.ReadToEnd();

        //        foreach (string token in retVal.Split('&'))
        //        {
        //            tokens.Add(token.Substring(0, token.IndexOf("=")),
        //                token.Substring(token.IndexOf("=") + 1, token.Length - token.IndexOf("=") - 1));
        //        }
        //    }

        //    return tokens;
        //}

        public ActionResult Index()
        {
            //AbmsgDbContext ctx = new AbmsgDbContext();
            //ANew aSimpleNews = new ANew() { Text = "This is the textt of the news", Title="This is the title of the news" };
            //ctx.News.Add(aSimpleNews);
            //ctx.SaveChanges();
            return View();
        }

        public ActionResult Responsables()
        {
            return View();
        }

        public ActionResult RallyCap()
        {
            return View();
        }

        public ActionResult NewsEdit()
        {
            return View();
        }
    }
}
