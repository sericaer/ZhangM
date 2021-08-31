using System;
using System.Collections;
using System.Collections.Generic;


namespace ZhangM
{
    public class PersonManager : IEnumerable<IPerson>
    {
        private List<IPerson> all = new List<IPerson>();
        public IEnumerator<IPerson> GetEnumerator()
        {
            return ((IEnumerable<IPerson>)all).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)all).GetEnumerator();
        }

        public void Build()
        {
            var person1 = new Person("AAAA");
            all.Add(person1);

            var person2 = new Person("BBBB");
            all.Add(person2);

            var person3 = new Person("CCCC");
            all.Add(person3);

        }
    }
}
