﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiItNews.Models
{
    public class FooterArticleModel
    {
        public List<ArticleModel> listes { get; set; }
        public string Img { get; set; }
    }
}