using System;
using System.ComponentModel;

namespace ZhangM
{
    public class Date : IDate
    {

        private int _total;

        public int total => _total;

        public int year { get { return total / 360 + 1; }  }


        public int month { get { return (total % 360) / 30 + 1; } }


        public int day { get { return total % 30 + 1; } }

        public (int y, int m, int d) value => (year, month, day);


        public Date() 
        {
            _total = 0;
        }

        public void Inc()
        {
            _total++;
        }
    }
}
