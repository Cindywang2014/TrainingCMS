namespace Training.Service
{
    public class ServiceFactory
    {
        public static IUserService GetUserService()
        {
            return new UserService();
        }

        public static IMovieService GetMovieService()
        {
            return new MovieService();
        }

        public static IMovieTypeService GetMovieTypeService()
        {
            return new MovieTypeService();
        }
        public static ICountryService GetCountryService()
        {
            return new CountryService();
        }
    }
}
