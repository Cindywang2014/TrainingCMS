using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;

namespace Training.Data
{
    public class MovieStore:IMovieStore
    {
        public int AddMovie(Movie movie)
        {
            var sql = string.Format(@"insert into [dbo].[Movie](MovieTypeId,MovieName,Description,Actor,Image,UploadDate,IsAudit) 
                                    values(@MovieTypeId,@MovieName,@Description,@Actor,@Image,@UploadDate,@IsAudit)");
            var parameters = new List<SqlParameter>
           {
               new SqlParameter("@MovieTypeId", movie.MovieTypeId),
               new SqlParameter("@MovieName", movie.MovieName),
               new SqlParameter("@Description", movie.Description),
               new SqlParameter("@Actor", movie.Actor),
               new SqlParameter("@Image", movie.Image),
               new SqlParameter("@UploadDate", movie.UploadDate),
               new SqlParameter("@IsAudit", movie.IsAudit)
           };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }

        public int UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public int DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
