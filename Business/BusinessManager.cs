using System;
using System.Collections;
using System.Collections.Generic;


namespace ZhangM
{
    public class BusinessManager  : IEnumerable<IBusiness>
    {
        private List<IBusiness> all = new List<IBusiness>();

        public IEnumerator<IBusiness> GetEnumerator()
        {
            return ((IEnumerable<IBusiness>)all).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)all).GetEnumerator();
        }

        public void Build()
        {
            var business1 = new Business();
            all.Add(business1);
            var business2 = new Business();
            all.Add(business2);
            var business3 = new Business();
            all.Add(business3);
        }


    }
}
