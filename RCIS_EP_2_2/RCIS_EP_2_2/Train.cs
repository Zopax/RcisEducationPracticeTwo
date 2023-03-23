using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCIS_EP_2_2
{
    internal class Train
    {
        public string destinationName { get; }
        public int trainNum { get; }
        public DateTime timeToStart { get; }

        public Train(string destName, int trainNum, DateTime timeToStart)
        {
            destinationName = destName;
            this.trainNum = trainNum;
            this.timeToStart = timeToStart;
        }
    }
}
