using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_6
{
    public class Temp
    {
        public int temp { get; }
        public int feelsLike { get; }
        public int tempMin { get; }
        public int tempMax { get; }
        public int pressure { get; }
        public int humidity { get;  }

        public Temp(int temp, int feelsLike, int tempMin, int tempMax, int pressure, int humidity)
        {
            this.temp = temp - 273;
            this.feelsLike = feelsLike - 273;
            this.tempMin = tempMin - 273;
            this.tempMax = tempMax - 273;
            this.pressure = pressure;
            this.humidity = humidity;
        }
    }
}
