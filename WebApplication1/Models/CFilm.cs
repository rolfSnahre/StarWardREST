using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CFilm
    {
        public CFilm() { }
        public CFilm(string director, string title)
        {
            this.director = director;
            this.title = title;
        }
        public string director;
        public string title;

    }
}