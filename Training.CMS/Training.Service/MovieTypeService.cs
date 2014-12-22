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
        public int ExperimentalType(MovieType movietype)
        {
            return StoreFactory.GetMovieTypeStore().ExperimentalType(movietype);
        }
        public int AddMovieType(MovieType movietype)
        {

            return StoreFactory.GetMovieTypeStore().AddMovieType(movietype);

        }
        public int UpdateMovieType(MovieType movietype)
        {
            return MovieTypeStore.UpdateMovieType(movietype);

        }

        public int DeteleMovieType(MovieType movietype)
        {
            return MovieTypeStore.DeteleMovieType(movietype);

        }

        public DataTable GetMovieTypes()
        {
            return MovieTypeStore.GetMovieTypes();
        }
    }
}
