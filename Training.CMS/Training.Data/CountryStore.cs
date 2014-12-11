using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;


namespace Training.Data
{
    public class CountryStore : ICountryStore
    {
        public int AddCountry(Country country)
        {
            var sql = string.Format(@"insert into [dbo].[Country](CountryName) values(@CountryName)");
            var parameters = new List<SqlParameter>
           {
               new SqlParameter("@CountryName", country.CountryName),
           };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }
        public int UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public int DeleteCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable GetCountries()
        {
            string command = string.Format(@"select * from [dbo].[Country]");
            return DBHelper.GetDataSet(command);
        }
    }
}
