using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Film
    {
        public Film() { }
        public Film(string director, string title)
        {
            this.director = director;
            this.title = title;
        }
        public string director;
        public string title;

    }
}