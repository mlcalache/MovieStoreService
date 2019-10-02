using MovieStoreService.Models;
using System;
using System.Collections.Generic;
using System.Web.Services;

namespace MovieStoreService
{
    /// <summary>
    /// Summary description for MovieStoreService
    /// </summary>
    [WebService(Namespace = "http://moviestoreservice.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class MovieStoreServiceSimplified : WebService
    {
        [WebMethod]
        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<Actor> GetCastByMovie(string movie)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Movie RegisterNewMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            throw new NotImplementedException();
        }
    }
}