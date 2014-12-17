using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Training.Domain;

namespace Training.Data
{
    public class MovieTypeStore : IMovieTypeStore
    {
        private string Command;
        public int ExperimentalType(MovieType movietype)
        {

            var sql = string.Format(@"select count(*) from MovieType where TypeName=(@typeName)");
            var parametsers = new List<SqlParameter>
           {
               new SqlParameter("@typeName",movietype.TypeName)
           };
            return DBHelper.GetScalar(sql, parametsers.ToArray());
        }
        public int AddMovieType(MovieType movietype)
        {
            Command = string.Format(@"insert into [dbo].[MovieType](TypeName) values(@TypeName)");
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@TypeName",movietype.TypeName)
            };
            return DBHelper.ExecuteCommand(Command, parameters.ToArray());
        }

        public int UpdateMovieType(MovieType movietype)
        {
            var sql = string.Format(@"update [dbo].[MovieType] set TypeName=(@typename) where Id=(@TypeID)");
            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@TypeID",movietype.Id),
                new SqlParameter("@typename",movietype.TypeName)          
        };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            //throw new System.NotImplementedException();
        }

        public int DeteleMovieType(MovieType movietype)
        {
            var sql = string.Format(@"delete from [dbo].[MovieType] where id=(@TypeID)");
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@TypeID",movietype.Id)

            };
            return DBHelper.ExecuteCommand(sql,parameters.ToArray());
            throw new System.NotImplementedException();
        }

        public DataTable GetMovieTypes()
        {
            Command = string.Format(@"select * from [dbo].[MovieType]");
            return DBHelper.GetDataSet(Command);
        }
    }
}
