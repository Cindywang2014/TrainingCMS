using System.Data;
using System.Data.SqlClient;
using Training.Domain;

namespace Training.Data
{
    public interface IUserStore
    {
        /// <summary>
        /// add a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int AddUser(User user);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int UpdateUser(User user);
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int DeteleUser(User user);
        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        DataTable GetUsers();
        /// <summary>
        /// Check same user's name in register page
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        SqlDataReader CheckRegisterUser(User user);

        
    }
}
