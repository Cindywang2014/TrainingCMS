using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;

namespace Training.Service
{
   public interface ICountryService
    {
        int ExperimentalCountry(Country country);
        /// <summary>
        /// add a country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        int AddCountry(Country country);
        /// <summary>
        /// Update a country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        int UpdateCountry(Country country);
        /// <summary>
        /// Delete a country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        int DeleteCountry(Country country);
        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns></returns>
        DataTable GetCountries();
    }
}
