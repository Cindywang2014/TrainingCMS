namespace Training.Domain
{
    public class User
    {
        public User()
        {
                
        }
        /// <summary>
        /// User's id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// User's name 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// User's password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// User's Email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// User belong Country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// User belong Region
        /// </summary>
        public string Region { get; set; }

       
    }
}
