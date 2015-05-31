using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlog.DAL
{
    public class ArticleContext:DbContext
    {
        public ArticleContext() : base("ArticleContext") { }

        public DbSet<Article> Articles { get; set; }
    }
}