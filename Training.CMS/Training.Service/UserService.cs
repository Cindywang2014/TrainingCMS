using System;
using System.Data;
using System.Data.SqlClient;
using Training.Data;
using Training.Domain;

namespace Training.Service
{
   public class UserService:IUserService
   {
        private readonly IUserStore UserStore;

        public UserService()
        {
            UserStore = StoreFactory.GetUserStore();
        }
        public int AddUser(User user) 
        {
            return UserStore.AddUser(user);
        }

        public int UpdateUser(User user)
        {
            return UserStore.UpdateUser(user);
        }

        public int DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public DataTable GetUsers()
        {
            return UserStore.GetUsers();
        }
        public SqlDataReader CheckRegisterUser(string userName)
        {
            return UserStore.CheckRegisterUser(userName);
        }

        public SqlDataReader CheckLogin(string userName, string password)
        {
            return UserStore.CheckLogin(userName,password);
        }
   }
}
