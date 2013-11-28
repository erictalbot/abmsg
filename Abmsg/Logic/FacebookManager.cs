using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abmsg.Logic
{
    public sealed class FacebookManager
    {
        #region private properties

        private static readonly FacebookManager instance = new FacebookManager();
        private FacebookManager() { }

        #endregion

        #region public properties

        public static FacebookManager Instance
        {
            get
            {
                return instance;
            }
        }

        public string AccessToken { get; set; }

        #endregion 

    }
}