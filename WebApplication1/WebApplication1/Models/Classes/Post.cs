using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Post
    {
        [Key] 
        public int postid { get; set; }

        public string posttxt { get; set; }

        public DateTime postdate { get; set; }

        public int postlike { get; set; }


    }
}