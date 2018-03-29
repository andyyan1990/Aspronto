using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aspronto.Model;
using System.Net.Http;
using Newtonsoft.Json;
using Aspronto.Helper;

namespace Aspronto.Logic
{
    public static class SO2Logic
    {
        public async static Task<List<SO2_Data>> GetSO2(double lat, double lon)
        {

            List<SO2_Data> sO2s = new List<SO2_Data>();



            using (HttpClient client = new HttpClient())
            {
                var url = "http://api.openweathermap.org/pollution/v1/so2/" + ((int)lat).ToString() + "," + ((int)lon).ToString() + "/" + Constant.CURRENT + ".json?appid=" + Constant.API_KEY;
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var SO2Info = JsonConvert.DeserializeObject<SO2>(json);

                sO2s = SO2Info.Data as List<SO2_Data>;
            }
            return sO2s;
        }
    }
}
