using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Domain;
using Training.Service;

namespace Training.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void AddUserTest()
        {
            var user = new User
            {
                UserName = "Cindy.wang",
                Password = "Test123.",
                EmailAddress = "Test@163.com",
                Country = "China",
                Region = "Heilongjiang harbin 1125"
            };

            var userService = new UserService();
            var result=userService.AddUser(user);

            Assert.AreEqual(1, result);
        }
    }
}
