using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abmsg.dto;
using abmsgFB;
using AbmsgModel;
using AbmsgModel.Data;

namespace Abmsg.Logic
{
    public class NewsManager
    {
        #region properties 

        private string _accessToken;
        private IUow _uow;
        private NewsDto _aNews;

        #endregion 

        #region ctor

        public NewsManager(NewsDto aNews, IUow uow)
        {
            _uow = uow;
            _aNews = aNews;
        }

        public bool Apply()
        {
            if (_aNews.Id == 0)
            {
                AddNews();
                return true;
            }
            else
            {
               return EditNews();
            }

        }

        #endregion 

        #region private methods 

        private void AddNews()
        {
            _uow.News.Add(new AbmsgModel.Data.News(_aNews.Title, _aNews.Content));
            _uow.Commit();
            _accessToken = GetAccessToken();
            PostToFacebook();
        }

        private bool EditNews()
        {
            News theNews = _uow.News.GetById(_aNews.Id);
            if (theNews != null)
            {
                theNews.Text = _aNews.Content;
                theNews.Title = _aNews.Title;
                _uow.Commit();
                return true;
            }
            return false;
        }

        private string GetAccessToken()
        {
            return FacebookManager.Instance.AccessToken;
        }


        private void PostToFacebook()
        {
            FacebookMethods fm = new FacebookMethods(_accessToken);
            fm.post(_aNews.Title, _aNews.Content);
        }

        #endregion 
    }
}