﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbmsgModel.Data
{
    public class News
    {
        public News(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}