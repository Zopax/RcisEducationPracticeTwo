using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_6
{
    public class Wind
    {
        public int speed { get; }
        public string? deg { get; }

        public Wind(int speed, int deg)
        {
            this.speed = speed;

            if (deg == 0 || deg == 360) this.deg = "Север";
            if (deg == 90) this.deg = "Восток";
            if (deg == 180) this.deg = "Юг";
            if (deg == 270) this.deg = "Запад";

            if (deg > 0 && deg < 90) this.deg = "Северо-Восток";
            if (deg > 90 && deg < 180) this.deg = "Юго-Восток";
            if (deg > 180 && deg < 270) this.deg = "Юго-Запад";
            if (deg > 270 && deg < 360) this.deg = "Северо-Запад";
        }
    }
}
