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
   public class RegionService:IRegionService
    {
       public int ExperimentalRegionCount(Region region)
       {
           return StoreFactory.GetRegionStore().ExperimentalRegionCount(region);
       }
       public int ExperimentalRegion(Region region)
       {
           return StoreFactory.GetRegionStore().ExperimentalRegion(region);
       }
        public int AddRegion(Region region)
        {
           
            return StoreFactory.GetRegionStore().AddRegion(region);
            
        }

        public int UpdateRegion(Region region)
        {
            return StoreFactory.GetRegionStore().UpdateRegion(region);
        }

        public int DeleteRegion(Region region)
        {
           
            return StoreFactory.GetRegionStore().DeleteRegion(region);
        }

        public System.Data.DataTable GetRegions()
        {
           
            return StoreFactory.GetRegionStore().GetRegions();
           
        }
    }
}
