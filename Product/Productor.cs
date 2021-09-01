using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class Productor : IComponentProductor
    {
        public ICondition condition => throw new NotImplementedException();

        public IProduct pdt => throw new NotImplementedException();

        public Type GetInterfaceType()
        {
            return typeof(IComponentProductor);
        }
    }
}
