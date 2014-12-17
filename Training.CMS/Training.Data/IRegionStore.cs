using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Domain;
using System.Data;

namespace Training.Data
{
  public interface IRegionStore
    {

      int ExperimentalRegionCount(Region region);
        int ExperimentalRegion(Region region);
        int AddRegion(Region region);
        int UpdateRegion(Region region);
        int DeleteRegion(Region region);
        DataTable GetRegions();
    }
}
