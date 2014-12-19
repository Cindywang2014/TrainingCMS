using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Data;
using Training.Domain;

namespace Training.Service
{
   public  class CountryService:ICountryService
    {

       public DataTable GetSelectRegion(int countryId)
       {
           return StoreFactory.GetCountryStore().GetSelectRegion(countryId);
       }
       public int ExperimentalCountry(Country country)
       {
           return StoreFactory.GetCountryStore().ExperimentalCountry(country);
       }

        public int AddCountry(Country country)
        {
           return StoreFactory.GetCountryStore().AddCountry(country);
        }

        public int UpdateCountry(Country country)
        {
            return StoreFactory.GetCountryStore().UpdateCountry(country);
        }

        public int DeleteCountry(Country country)
        {
            return StoreFactory.GetCountryStore().DeleteCountry(country);
        }
       public int DeleteCountryOfRegion(Country country)
        {
            return StoreFactory.GetCountryStore().DeleteCountryOfRegion(country);
        }

        public DataTable GetCountries()
        {
            return StoreFactory.GetCountryStore().GetCountries();
           // return new CountryStore().GetCountries();
        }

        public Country country { get; set; }
    }
}
