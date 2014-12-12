using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;

namespace Training.Service
{
    public interface IMovieService
    {
        /// <summary>
        /// add a movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int AddMovie(Movie movie);
        /// <summary>
        /// update a movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int UpdateMovie(Movie movie);
        /// <summary>
        /// delete a movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int DeleteMovie(Movie movie);
        /// <summary>
        /// get all movies
        /// </summary>
        /// <returns></returns>
        DataTable GetMovies();

        DataTable GetMovies(string typename,string actor);
    }
}
