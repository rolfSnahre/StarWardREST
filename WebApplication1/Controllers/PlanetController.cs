using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlanetController : ApiController
    {
        public Planet Get()
        {
            String name = "aaa";
            int population = 300;

            List<Film> films = new List<Film>();
            List<Resident> residents = new List<Resident>();

            Film film1 = new Film("Bay", "return of the");
            Film film2 = new Film("tarantino", "pulp");

            films.Add(film1);
            films.Add(film2);     

            Resident resident = new Resident(2000, "Peter", "Mann");

            residents.Add(resident);

            Planet planet = new Planet(name, population, films, residents);
            
            return planet;
        }
    }
}
