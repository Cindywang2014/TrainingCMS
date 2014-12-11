using Training.Data;
using Training.Domain;
using System.Data;

namespace Training.Service
{
    public class MovieTypeService : IMovieTypeService
    {
        private readonly IMovieTypeStore MovieTypeStore;

        public MovieTypeService()
        {
            MovieTypeStore = StoreFactory.GetMovieTypeStore();
        }
        public int AddMovieType(MovieType movietype)
        {

            return MovieTypeStore.AddMovieType(movietype);
        }
        public int UpdateMovieType(MovieType movietype)
        {
            throw new System.NotImplementedException();
        }

        public int DeteleMovieType(MovieType movietype)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetMovieTypes()
        {
            return new MovieTypeStore().GetMovieTypes();
        }
    }
}
