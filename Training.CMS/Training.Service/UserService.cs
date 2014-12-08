using System.Data;
using Training.Data;
using Training.Domain;

namespace Training.Service
{
   public class UserService:IUserService
    {
        public int AddUser(User user)
        {
            return StoreFactory.GetUserStore().AddUser(user);
        }

        public int UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public int DeteleUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}
