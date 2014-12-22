using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Training.Domain;

namespace Training.Data
{
    public class UserStore : IUserStore
    {
        public int AddUser(User user)
        {
            var sql = string.Format(@"insert into [dbo].[User](UserName,Password,EmailAddress,Country,Region) values(@UserName,@Password,@EmailAddress,@Country,@Region)");
            var parameters = new List<SqlParameter>
           {
               new SqlParameter("@UserName", user.UserName),
               new SqlParameter("@Password", user.Password),
               new SqlParameter("@EmailAddress", user.EmailAddress),
               new SqlParameter("@Country", user.Country),
               new SqlParameter("@Region", user.Region)
           };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }

        public int UpdateUser(User user)
        {
            var sql = string.Format(@"update [dbo].[User] set Password=@Password,EmailAddress=@EmailAddress,Country=@Country,Region=@Region where UserName=@UserName");
            var parameters = new List<SqlParameter>
            {
                 new SqlParameter("@UserName",user.UserName),
                 new SqlParameter("@Password",user.Password),
                 new SqlParameter("@EmailAddress",user.EmailAddress),
                 new SqlParameter("@Country",user.Country),
                 new SqlParameter("@Region",user.Region),
            };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }

        public int DeleteUser(User user)
        {
            //var sql = string.Format(@"delete from [dbo].[User] where ID=@ID");
            //var parameters = new List<SqlParameter>
            //{
            //     new SqlParameter("@ID",user.Id),
            //};
            //return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            return 1;
        }

        public System.Data.DataTable GetUsers()
        {
            var sql = string.Format(@"select * from [dbo].[User]");
            return DBHelper.GetDataSet(sql);
        }

        public SqlDataReader CheckRegisterUser(string userName)
        {
            var sql = string.Format(@"select * from [dbo].[User] where UserName=@UserName");
            var parameters = new List<SqlParameter>
           {
           new SqlParameter("@UserName", userName)
           };
            return DBHelper.GetReader(sql, parameters.ToArray());
        }

        public SqlDataReader CheckLogin(string userName, string password)
        {
            var sql = string.Format(@" select * from [dbo].[User] where UserName=@UserName and Password=@Password");
            var parameters = new List<SqlParameter>
           {
             new SqlParameter("@UserName", userName),
              new SqlParameter("@Password", password),
           };
            return DBHelper.GetReader(sql, parameters.ToArray());
        }
    }
}
