namespace Training.Data
{
    public class StoreFactory
    {
        public static IUserStore GetUserStore()
        {
            return new UserStore();
        }

        public static ICountryStore GetCountryStore()
        {
            return new CountryStore();
        }

        public static IMovieStore GetMovieStore()
        {
            return new MovieStore();
        }
        
        public static IMovieTypeStore GetMovieTypeStore()
        {
            return new MovieTypeStore();
        }
        public static IRegionStore GetRegionStore()
        {
            return new RegionStore();
        }
    }
}
