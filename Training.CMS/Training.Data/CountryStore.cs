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

        //public int A(Region region)
        //{
        //    var sql = string.Format(@"select count(*) from Region where CountryId=(@CountryId)");
        //    var parametsers = new List<SqlParameter>
        //    {
        //        new SqlParameter("@CountryId",region.CountryId)
        //    };
        //    return DBHelper.GetScalar(sql, parametsers.ToArray());
        //}
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
            // var sql = string.Format(@"insert into Country select Countryname from Country where not exists(select CountryName from Country where CountryName =(@CountryName))");
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
            //   string sql = "delete from [dbo].[Country] where Id=(@countryID)";
            //   var parameters = new List<SqlParameter>
            //    { 
            //        new SqlParameter("@countryID",country.Id),                           
            //};
            //   return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            throw new NotImplementedException();
        }
        public DataTable GetCountries()
        {
            var sql = string.Format(@"select * from [dbo].[Country]");

            return DBHelper.GetDataSet(sql);
        }


        public int DeleteCountry(Country country)
        {

            string sql = "delete from [dbo].[Country] where Id=(@countryID)";

            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@countryID",country.Id)                         
        };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            throw new NotImplementedException();
        }
    }
}