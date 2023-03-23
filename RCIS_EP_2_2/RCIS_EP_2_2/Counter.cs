using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_2
{
    public class Counter
    {
        public int i { get; set; } = 1;

        public int Increase() => ++i;
        public int Reduce() => --i;
    }
}
