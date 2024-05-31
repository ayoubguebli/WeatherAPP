using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather_APP
{
    public class forecast
    {
        public string location { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }

        public CurrentData current { get; set; }
    }

    public class CurrentData
    {
        public double temperature_2m { get; set; }
        public double wind_speed_10m { get; set; }
        public string time { get; set; }
    }
}

