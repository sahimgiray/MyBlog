using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Article
    {
        public Article()
        {

        }

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Html)]
        public string Content { get; set; }

    }
}