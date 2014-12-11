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
        public int AddMovie(Movie movie)
        {
            return StoreFactory.GetMovieStore().AddMovie(movie);
        }

        public int UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public int DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public DataTable GetMovies()
        {
            throw new NotImplementedException();
        }
        public DataTable GetMovies(string typename, bool istypename)
        {
            return StoreFactory.GetMovieStore().GetMovies(typename, istypename);
        }

        public DataTable GetMovies(string typename, string actor)
        {
            return StoreFactory.GetMovieStore().GetMovies(typename, actor);
        }
    }

}
