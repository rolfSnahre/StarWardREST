using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication1.Models;
using SharpTrooper.Core;
using SharpTrooper.Entities;

namespace WebApplication1.Controllers
{
    public class PlanetController : ApiController
    {
        SharpTrooperCore ST = new SharpTrooperCore();
        static HttpClient client = new HttpClient();

        public string Get()
        {
            return "Missing ID";
        }

        public CPlanet Get(string id)
        {

            


            Planet planet = ST.GetPlanet(id);

            List<CFilm> cFilms = new List<CFilm>();
            List<CResident> cResidents = new List<CResident>();

            String name = planet.name;
            String population = planet.population;

            foreach(string filmURI in planet.films)
            {
                addFilm(cFilms, filmURI);
            }

            foreach (string resURI in planet.residents)
            {
                addRes(cResidents, resURI);
            }


            CPlanet cPlanet = new CPlanet(name, population, cFilms, cResidents);

            return cPlanet;
        }

        private void addFilm(List<CFilm> films, string filmURI)
        {
            string[] split_string = filmURI.Split('/');
            string filmNum = split_string[split_string.Length - 2];
            Film film = ST.GetFilm(filmNum);
            CFilm cFilm = new CFilm(film.director, film.title);
            films.Add(cFilm);
        }

        private void addRes(List<CResident> residents, string resURI)
        {
            string[] split_string = resURI.Split('/');
            string resNum = split_string[split_string.Length - 2];
            People res = ST.GetPeople(resNum);
            CResident cRes = new CResident(res.birth_year, res.name, res.gender);
            residents.Add(cRes);
        }

        
    }
}



/*
 * String name = "aaa";
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

*/


/*
    private async Task setupClient()
    {

        client.BaseAddress = new Uri("https://spv-swapi.herokuapp.com/api/");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    private async Task<Dictionary<string,Object>> getDict(string path)
    {
        Dictionary<string, Object> dict = null;

        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            dict = await response.Content.ReadAsAsync<Dictionary<string, Object>>();             
        }
        return dict;
    }

    private async Task<Dictionary<string, Object>> getPlanetDict(int id)
    {
        string path = "planets/" + id;
        return await getDict(path);
    }
    */
