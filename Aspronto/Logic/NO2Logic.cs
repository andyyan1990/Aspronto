using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aspronto.Model;
using System.Net.Http;
using Newtonsoft.Json;
using Aspronto.Helper;

namespace Aspronto.Logic
{
    public static class NO2Logic
    {
        public async static Task<List<NO2_Data>> GetNO2(double lat, double lon)
        {

            List<NO2_Data> nO2s = new List<NO2_Data>();



            using (HttpClient client = new HttpClient())
            {
                var url = "http://api.openweathermap.org/pollution/v1/no2/" + ((int)lat).ToString() + "," + ((int)lon).ToString() + "/" + Constant.CURRENT + ".json?appid=" + Constant.API_KEY;
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var NO2Info = JsonConvert.DeserializeObject<NO2>(json);

                nO2s = NO2Info.Data as List<NO2_Data>;
            }
            return nO2s;
        }
    }
}
