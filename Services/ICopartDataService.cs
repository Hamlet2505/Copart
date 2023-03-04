using Copart.Models.LotData;
using Copart.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Copart.Services
{
    public interface ICopartDataService
    {
        public LotDetailsOutput GetLotDetails(string lotNumber);
    }
}
