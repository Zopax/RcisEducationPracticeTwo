using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_6
{
    public  class Cloud
    {
        public string cloudInfo { get; }

        public Cloud(int cloud)
        {
            if (cloud >= 0 && cloud <= 3) this.cloudInfo = "Ясно";
            if (cloud >= 3 && cloud <= 7) this.cloudInfo = "Переменная облачность";
            if (cloud >= 8 && cloud <= 10) this.cloudInfo = "Пасмурно";
        }
    }
}
