using System;
namespace Aspronto.Helper
{
    public class Constant
    {
        //{1} is Lat, {2} is Lon, {3} is datetime
        public const string CO_SEARCH = "http://api.openweathermap.org/pollution/v1/co/{1},{2}/{3}.json?appid={4}";
        public const string API_KEY = "eca450ce4759df0ac1b0fa9604daeb34";
        public const string CURRENT = "current";

    }
}
