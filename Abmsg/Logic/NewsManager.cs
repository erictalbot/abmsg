using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abmsg.dto;
using abmsgFB;

namespace Abmsg.Logic
{
    public class NewsManager
    {
        #region properties 

        private string _accessToken;


        #endregion 

        #region ctor

        public NewsManager(ANews aNews)
        {
            _accessToken = GetAccessToken();
            PostToFacebook();

        }

        #endregion 

        #region private methods 

        private string GetAccessToken()
        {
            return FacebookManager.Instance.AccessToken;
        }


        private void PostToFacebook()
        {
            FacebookMethods am = new FacebookMethods(_accessToken);
            //am.post();
        }

        #endregion 
    }
}