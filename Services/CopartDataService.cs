using Copart.Models.Data;
using Copart.Models.LotData;
using Copart.Models.Output;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Copart.Services
{
    public class CopartDataService : ICopartDataService
    {
        public LotDetailsOutput GetLotDetails(string lotNumber)
        {
            var url = "https://www.copart.com/public/data/lotdetails/solr/" + lotNumber + "";
            string json = new System.Net.WebClient().DownloadString(url);
            var lotDetails = JsonConvert.DeserializeObject<Car_atr>(json);

            string json_img = new WebClient().DownloadString("https://www.copart.com/public/data/lotdetails/solr/lotImages/" + lotNumber + "/USA");
            var lotImg = JsonConvert.DeserializeObject<Car_img>(json_img);

            return new LotDetailsOutput { car_Atr = lotDetails, car_Img = lotImg };
        }
    }
}
