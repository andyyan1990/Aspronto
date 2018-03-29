using System;
using System.Collections.Generic;

namespace Aspronto.Model
{
    //public class Location
    //{
    //    public double Latitude { get; set; }
    //    public double Longitude { get; set; }
    //}

    public class SO2_Data
    {
        public double Precision { get; set; }
        public double Pressure { get; set; }
        public double Value { get; set; }
    }

    public class SO2
    {
        public DateTime Time { get; set; }
        public Location Location { get; set; }
        public IList<SO2_Data> Data { get; set; }
    }
}
