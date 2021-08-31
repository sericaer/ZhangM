using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface IDate
    {
        int total { get;}

        (int y, int m, int d) value { get; }

        void Inc();
    }
}
