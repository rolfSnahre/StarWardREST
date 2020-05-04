using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CResident
    {
        public CResident() { }
        public CResident(string birth_year, string name, string gender)
        {
            this.birth_year = birth_year;
            this.name = name;
            this.gender = gender;
        }
        public string birth_year;
        public string name;
        public string gender;
    }
}