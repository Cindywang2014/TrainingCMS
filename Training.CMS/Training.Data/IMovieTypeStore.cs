using System.Data;
using Training.Domain;

namespace Training.Data
{
    public interface IMovieTypeStore
    {
        int ExperimentalType(MovieType movietype);
        int AddMovieType(MovieType movietype);

        int UpdateMovieType(MovieType movietype);

        int DeteleMovieType(MovieType movietype);

        DataTable GetMovieTypes();
    }
}
