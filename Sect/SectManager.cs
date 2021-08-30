using System;
using System.Collections;
using System.Collections.Generic;


namespace ZhangM
{
    public class SectManager : IEnumerable<ISect>
    {
        private List<ISect> all = new List<ISect>();

        public IEnumerator<ISect> GetEnumerator()
        {
            return ((IEnumerable<ISect>)all).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)all).GetEnumerator();
        }

        public void build()
        {
            var sect1 = new Sect();
            var sect2 = new Sect();
            var sect3 = new Sect();

            all.AddRange(new ISect[] { sect1, sect2, sect3 });
        }


    }
}
