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
       private readonly ICountryStore CountryStore;

       public CountryService()
        {
            CountryStore = StoreFactory.GetCountryStore();
        }

        public int AddCountry(Country country)
        {
            return CountryStore.AddCountry(country);
        }

        public int UpdateCountry(Country country)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteCountry(Country Country)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetCountries()
        {

            return new CountryStore().GetCountries();
        }
    }
}
