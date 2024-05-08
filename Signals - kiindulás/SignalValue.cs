using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signals
{
    public class SignalValue
    {
        private double _value = 0;

        private DateTime timeStamp;


        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public SignalValue(double value, DateTime timeStamp)
        {
            TimeStamp = timeStamp;
            Value = value;
        }

    }
}
