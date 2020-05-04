using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Resident
    {
        public Resident() { }
        public Resident(int birth_year, string name, string gender)
        {
            this.birth_year = birth_year;
            this.name = name;
            this.gender = gender;
        }
        public int birth_year;
        public string name;
        public string gender;
    }
}