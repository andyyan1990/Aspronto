using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aspronto.Model;
using System.Net.Http;
using Newtonsoft.Json;
using Aspronto.Helper;

namespace Aspronto.Logic
{
    public static class COLogic
    {
        public async static Task<List<CO_Data>> GetCO(double lat, double lon){

            List < CO_Data> cOs= new List<CO_Data>();



            using(HttpClient client = new HttpClient())
            {
                var url = "http://api.openweathermap.org/pollution/v1/co/" + ((int)lat).ToString() + "," + ((int)lon).ToString()+ "/" + Constant.CURRENT + ".json?appid=" + Constant.API_KEY;
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var COInfo = JsonConvert.DeserializeObject<CO>(json);

                cOs = COInfo.Data as List<CO_Data>;
            }
            return cOs;
        }
    }
}
