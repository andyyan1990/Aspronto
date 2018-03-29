using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aspronto.Model;
using System.Net.Http;
using Newtonsoft.Json;
using Aspronto.Helper;

namespace Aspronto.Logic
{
    public static class O3Logic
    {
        public async static Task<List<O3_Data>> GetO3(double lat, double lon)
        {

            List<O3_Data> O3s = new List<O3_Data>();



            using (HttpClient client = new HttpClient())
            {
                var url = "http://api.openweathermap.org/pollution/v1/o3/" + ((int)lat).ToString() + "," + ((int)lon).ToString() + "/" + Constant.CURRENT + ".json?appid=" + Constant.API_KEY;
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var O3Info = JsonConvert.DeserializeObject<CO>(json);

                O3s = O3Info.Data as List<O3_Data>;
            }
            return O3s;
        }
    }
}
