using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Training.Domain;

namespace Training.Data
{
    public class MovieTypeStore : IMovieTypeStore
    {
        private string Command;
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
            throw new System.NotImplementedException();
        }

        public int DeteleMovieType(MovieType movietype)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetMovieTypes()
        {
            Command = string.Format(@"select * from [dbo].[MovieType]");
            return DBHelper.GetDataSet(Command);
        }
    }
}
