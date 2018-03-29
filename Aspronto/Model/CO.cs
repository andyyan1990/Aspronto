using System;
using System.Collections.Generic;
using Aspronto.Helper;

namespace Aspronto.Model
{
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class CO_Data
    {
        public double Precision { get; set; }
        public double Pressure { get; set; }
        public double Value { get; set; }
    }

    public class CO
    {
        public DateTime Time { get; set; }
        public Location Location { get; set; }
        public IList<CO_Data> Data { get; set; }
    }


}
