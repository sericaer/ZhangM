using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public class Sect : Entity, ISect
    {
        public Sect()
        {
            
        }

        public IEnumerable<IPerson> persons
        {
            get
            {
                return subsidiaries.Select(x => x.owner);
            }
        }

        public IEnumerable<ISubsidiary> subsidiaries
        {
            get
            {
                return GetRealtaions<IRelation_Sect_Subsidiary>().Select(x=>x.subsidiary);
            }
        }
    }
}
