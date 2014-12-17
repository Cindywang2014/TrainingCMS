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
   public class RegionStore:IRegionStore 
    {        

       public int ExperimentalRegionCount(Region region)
       {
           var sql = string.Format(@"select count(RegionName) from Region where CountryId=(@CountryId)");
              var parametsers = new List<SqlParameter>
               {
                  new SqlParameter("@CountryId",region.CountryId)
              };
               return DBHelper.GetScalar(sql, parametsers.ToArray());
       }
       public int ExperimentalRegion(Region region)
       {
           var sql = string.Format(@"select count(*) from Region where RegionName=(@RegionName)");
           var parametsers = new List<SqlParameter>
           {
               new SqlParameter("@RegionName",region.RegionName)
           };
           return DBHelper.GetScalar(sql, parametsers.ToArray());
       }
        public int AddRegion(Region region)
        {
            var sql = string.Format(@"insert into [dbo].[Region](CountryId,RegionName)values(@CountryId,@RegionName)");
            var parameters = new List<SqlParameter>
           {
               new SqlParameter("@CountryId",region.CountryId),
               new SqlParameter("@RegionName",region.RegionName)
               
           };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
            //throw new NotImplementedException();
        }

        public int UpdateRegion(Region region)
        {
            //var sql=string.Format(@"update")
            var sql = string.Format(@"update [dbo].[Region] set RegionName=(@regionName) where Id=(@regionID)");
            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@regionID",region.Id),
                new SqlParameter("@regionName", region.RegionName)  
                
           // throw new NotImplementedException();
            };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray());
        }
        public int DeleteRegion(Region region)
        {
            string sql = "delete from [dbo].[Region] where Id=(@regionID)";
            var parameters = new List<SqlParameter>
            { 
                new SqlParameter("@regionID",region.Id),                           
        };
            return DBHelper.ExecuteCommand(sql, parameters.ToArray()); 
           // throw new NotImplementedException();
        }

        public DataTable GetRegions()
        {
            //var sql = string.Format(@"select * from [dbo].[Region]");
            var sql = string.Format(@"select b.Id,a.CountryName, b.RegionName from Country a inner join Region b on a.Id=b.CountryId");
            return DBHelper.GetDataSet(sql);
            //throw new NotImplementedException();
        }
    }
}
