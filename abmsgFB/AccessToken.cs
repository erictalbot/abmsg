using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace abmsgFB
{
    public class AccessToken
    {

        public string GetAccessTokenFromCode(string AppID, string AppSecret)
        {
            WebClient wc = new WebClient();
            string u2 = "https://graph.facebook.com/oauth/access_token?client_id=" + AppID + "&client_secret=" + AppSecret + "&grant_type=client_credentials";
            string access = wc.DownloadString(u2);
            access = access.Substring(access.IndexOf("access_token") + 13);
            if (access.Contains("&"))
            {
                string accesstoken = access.Substring(0, access.IndexOf("&"));
                return accesstoken;
            }
            return access;
        }


















        public string GetStatus(string accessToken)
        {

        

            //var args = new Dictionary<string, object>();
            //args["message"] = "Testing 123";
            //Facebook.FacebookClient fb = new Facebook.FacebookClient();
            //fb.AccessToken = fb.Post("oauth/access_token",
            //                      new
            //                      {
            //                          client_id = "762695377090736",
            //                          client_secret = "84d642357858c31f7b41b7802fa784dc",
            //                          grant_type = "client_credentials",
            //                      }).ToString();

            //Facebook.FacebookClient fb1 = new Facebook.FacebookClient(fb.AccessToken);
            //fb1.Post("/me/feed", args);
            //WebClient wc = new WebClient();
            //string url = "https://graph.facebook.com/me/statuses?access_token=" + accessToken;
            //////string url = "https://graph.facebook.com/AssociationBaseballMineurSaintGeorges/statuses?access_token=" + accessToken;
            //////string url = "https://graph.facebook.com/AssociationBaseballMineurSaintGeorges/feed?access_token=" + accessToken;
            //string access = wc.DownloadString(url);
            //return access;

            return string.Empty;
        }
    }
}
