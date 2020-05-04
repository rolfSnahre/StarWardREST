using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CPlanet
    {
        public CPlanet() { }
        public CPlanet(string name, string population, List<CFilm> films, List<CResident> residents)
        {
            this.name = name;
            this.population = population;
            this.films = films;
            this.residents = residents;
        }
        public string name;
        public string population;
        public List<CFilm> films;
        public List<CResident> residents;

    }
}