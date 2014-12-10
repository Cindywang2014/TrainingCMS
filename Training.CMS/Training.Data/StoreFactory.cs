﻿namespace Training.Data
{
    public class StoreFactory
    {
        public static IUserStore GetUserStore()
        {
            return new UserStore();
        }

        public static IMovieStore GetMovieStore()
        {
            return new MovieStore();
        }
    }
}
