using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using System.Dynamic;

namespace abmsgFB
{
    public class FacebookMethods
    {

        #region properties

        private string _accessToken;

        #endregion 

        #region ctor

        public FacebookMethods(string accessToken)
        {
            _accessToken = accessToken;
        }

        #endregion

        public void post(string title, string message)
        {
            dynamic messagePost = new ExpandoObject();
            //messagePost.picture = "http://yaplex.com/uploads/yaplex-logo-with-text-small.png";
            //messagePost.link = "http://yaplex.com/";
            messagePost.name = "[name] Facebook name...";

            // "{*actor*} " + "posted news..."; //<---{*actor*} is the user (i.e.: Alex)
            //messagePost.caption = " Facebook caption";
            //messagePost.description = "[description] Facebook description...";
            messagePost.message = "[" + title + "]" + message;

            string acccessToken = _accessToken;
            FacebookClient appp = new FacebookClient(acccessToken);
            try
            {
                var postId = appp.Post("AssociationBaseballMineurSaintGeorges" + "/feed", messagePost);
            }
            catch (FacebookOAuthException ex)
            {
                //handle oauth exception
            }
            catch (FacebookApiException ex)
            {
                //handle facebook exception
            }
        }
    }
}
