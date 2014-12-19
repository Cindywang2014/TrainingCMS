using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;
using System.Data;
using System.Data.SqlClient;
namespace Training.Data
{
    public class CountryStore : ICountryStore
    {
        public int ExperimentalCountry(Country country)
        {

            var sql = string.Format(@"select count(*) from Country where CountryName=(@CountryName)");
            var parametsers = new List<SqlParameter>
           {
               new SqlParameter("@CountryName",country.CountryName)
           };
            return DBHelper.GetScalar(sql, parametsers.ToArray());
        }
        public int AddCountry(Country country)
        {
            var sql = string.Format(@"insert into [dbo].[Country](CountryName)values(@CountryName)");
            var parameters = new List<SqlParameter>
           {
               new SqlParameter("@CountryName",country.CountryName)
           };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }
        public int UpdateCountry(Country country)
        {
            var sql = string.Format(@"update [dbo].[Country] set CountryName=(@countryname) where Id=(@countryID)");
            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@countryID",country.Id),
                new SqlParameter("@countryname", country.CountryName)          
        };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            //throw new System.NotImplementedException();
        }
        public int DeteleCountry(Country country)
        {
            throw new NotImplementedException();
        }
        public DataTable GetCountries()
        {
            var sql = string.Format(@"select * from [dbo].[Country]");

            return DBHelper.GetDataSet(sql);
        }


        public int DeleteCountry(Country country)
        {

            string sql = string.Format(@"delete from [dbo].[Country] where Id=(@countryID)");

            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@countryID",country.Id)                         
        };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            
        }
        public int DeleteCountryOfRegion(Country country)
        {
            string sql = string.Format(@"delete from [dbo].[Region] where CountryId=(@countryId)");
            var parameters=new List<SqlParameter>
            {
                new SqlParameter("@countryId",country.Id)
            };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }
        public DataTable GetSelectRegion(int countryId)
        {
            var sql = string.Format(@"select * from Region where CountryId=(@countryId)");
            var parametsers = new List<SqlParameter>
               {
                  new SqlParameter("@countryId",countryId)
              };
            return DBHelper.GetDataSet(sql, parametsers.ToArray());
        }
    }
}