using Training.Domain;
using System.Data;

namespace Training.Service
{
    public interface IMovieTypeService
    {
        int ExperimentalType(MovieType movietype);
        int AddMovieType(MovieType movietype);

        int UpdateMovieType(MovieType movietype);

        int DeteleMovieType(MovieType movietype);

        DataTable GetMovieTypes();
    }
}
