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
    public class MovieStoreService : WebService
    {
        //[WebMethod]
        //public void ChangeMovieCategory(int movieId, int categoryId)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public void ChangeMovieNationality(int movieId, int countryId)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Award> GetAllAwards()
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Gender> GetAllGenders()
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Country> GetAllCountries()
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        //[WebMethod]
        //public List<Movie> GetAllMoviesByActorName(string actorName)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Movie> GetAllMoviesByCategory(int categoryId)
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public List<Movie> GetAllMoviesByGender(string gender)
        {
            throw new NotImplementedException();
        }

        //[WebMethod]
        //public List<Movie> GetAllMoviesByCountry(int countryId)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Movie> GetAllMoviesByCountryName(string countryName)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Movie> GetAllMoviesByDirectorName(string directorName)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Movie> GetAllMoviesByProducerName(string producerName)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public List<Award> GetAwardsByMovie(int movieId)
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public List<Award> GetAwardsByMovie(string movie)
        {
            throw new NotImplementedException();
        }

        //[WebMethod]
        //public List<Actor> GetCastByMovie(int movieId)
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public List<Actor> GetCastByMovie(string movie)
        {
            throw new NotImplementedException();
        }

        //[WebMethod]
        //public Movie GetMovie(int movieId)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public Movie GetMovieByMovieName(string movieName)
        //{
        //    throw new NotImplementedException();
        //}

        //[WebMethod]
        //public Country RegisterNewCountry(string countryName)
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public Movie RegisterNewMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            throw new NotImplementedException();
        }

        //[WebMethod]
        //public bool RemoveMovie(int movieId)
        //{
        //    throw new NotImplementedException();
        //}

        [WebMethod]
        public bool RemoveMovie(string movie)
        {
            throw new NotImplementedException();
        }

        //[WebMethod]
        //public Movie UpdateMovie(int movieId, Movie movie)
        //{
        //    if (movie == null)
        //    {
        //        throw new ArgumentNullException(nameof(movie));
        //    }

        //    throw new NotImplementedException();
        //}
    }
}