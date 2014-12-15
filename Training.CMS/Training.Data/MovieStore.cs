using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;

namespace Training.Data
{
    public class MovieStore : IMovieStore
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
            string sql = string.Format(@"DELETE FROM [dbo].[Movie] WHERE (Id=@Id)");
            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@Id",movie.Id),
            };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }

        public DataTable GetMovies()
        {
            var sql = string.Format(@"SELECT * FROM [dbo].[Movie]");
            return DBHelper.GetDataSet(sql);
        }

        public DataTable GetMovies(string typename, string actor)
        {
            if (!typename.Equals("全部") && !string.IsNullOrEmpty(actor))
            {
                var sql = string.Format(@"select * from [dbo].[Movie] where MovieTypeId in (select Id from [dbo].[MovieType] where TypeName=@TypeName) and Actor=@Actor and IsAudit=1 order by UploadDate desc");
                var parameter = new List<SqlParameter>
            {
                new SqlParameter("@TypeName",typename),
                new SqlParameter("@Actor",actor)
            };
                return DBHelper.GetDataSet(sql, parameter.ToArray());
            }
            else if (typename.Equals("全部") && !string.IsNullOrEmpty(actor))
            {
                var sql = string.Format(@"select * from [dbo].[Movie] where Actor=@Actor and IsAudit=1 order by UploadDate desc");
                var parameter = new List<SqlParameter>
                {
                    new SqlParameter("@Actor",actor)
                };
                return DBHelper.GetDataSet(sql, parameter.ToArray());
            }
            else if (!typename.Equals("全部") && string.IsNullOrEmpty(actor))
            {
                var sql = string.Format(@"select * from [dbo].[Movie] where MovieTypeId in (select Id from [dbo].[MovieType] where TypeName = @TypeName) and IsAudit=1 order by UploadDate desc");
                var parameter = new List<SqlParameter>
            {
                new SqlParameter("@TypeName",typename)
            };
                return DBHelper.GetDataSet(sql, parameter.ToArray());
            }
            else
            {
                var sql = string.Format(@"select * from [dbo].[Movie] where IsAudit=1 order by UploadDate desc");
                return DBHelper.GetDataSet(sql);
            }

        }
    }
}
