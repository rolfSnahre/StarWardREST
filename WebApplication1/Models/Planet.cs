using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Planet
    {
        public Planet() { }
        public Planet(string name, int population, List<Film> films, List<Resident> residents)
        {
            this.name = name;
            this.population = population;
            this.films = films;
            this.residents = residents;
        }
        public string name;
        public int population;
        public List<Film> films;
        public List<Resident> residents;

    }
}