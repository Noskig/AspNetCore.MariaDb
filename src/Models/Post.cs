﻿using System;


namespace AspNetCore.MariaDB.Models
{
    public class Post
    {
        public int? Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public Post()
        {

        }
    }
}
