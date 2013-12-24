using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbmsgModel.Data;

namespace Abmsg.Models.Views
{
    public class HomeViewModel
    {

        #region properties

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        #endregion

        #region ctor


        public HomeViewModel(News news)
        {
            Id = news.Id;
            Title = news.Title;
            Text = news.Text;
            Date = news.Date;
        }

        #endregion




    }

}