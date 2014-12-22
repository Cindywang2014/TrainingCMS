using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Data;
using Training.Domain;

namespace Training.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieStore MovieStore;

        public MovieService()
        {
            MovieStore = StoreFactory.GetMovieStore();
        }
        public int ExperimentalMovieCount(Movie movie)
        {
            return MovieStore.ExperimentalMovieCount(movie);
        }
        public int AddMovie(Movie movie)
        {
            return MovieStore.AddMovie(movie);
        }

        public int UpdateMovie(Movie movie)
        {
            return MovieStore.UpdateMovie(movie);
        }

        public int DeleteMovie(Movie movie)
        {
            return MovieStore.DeleteMovie(movie);
        }

        public int IsAudit(Movie movie)
        {
            return MovieStore.IsAudit(movie);
        }
        public DataTable GetMovies()
        {
            return MovieStore.GetMovies();
        }

        public DataTable UnauditedMovie()
        {
            return MovieStore.UnauditedMovie();
        }
        public DataTable ShowMovie(int movieId)
        {
            return MovieStore.ShowMovie(movieId);
        }

        public DataTable ShowMovie(string movieName)
        {
            return MovieStore.ShowMovie(movieName);
        }

        public DataTable GetMovies(string typename, string actor)
        {
            if (actor.Equals("Input the name of actor or movie.."))
            {
                actor = string.Empty;
            }
            else
            {
                actor = actor.Trim();
            }
            return MovieStore.GetMovies(typename, actor);
        }
    }

}
