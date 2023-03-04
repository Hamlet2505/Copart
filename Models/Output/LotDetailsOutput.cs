using Copart.Models.Data;
using Copart.Models.LotData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Copart.Models.Output
{
    public class LotDetailsOutput
    {
        public Car_atr car_Atr { get; set; }
        public Car_img car_Img { get; set; }
    }
}
