using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public class Subsidiary : Entity, ISubsidiary
    {
        public ISect sect
        {
            get
            {
                var relation = GetRealtaions<IRelation_Sect_Subsidiary>().SingleOrDefault();
                return relation == null ? null : relation.sect;
            }
        }

        public IPerson owner
        {
            get
            {
                var relation =  GetRealtaions<IRelation_Person_Subsidiary>().SingleOrDefault();
                return relation == null ? null : relation.person;
            }
        }

        public IEnumerable<IBusiness> businesses
        {
            get
            {
                return GetRealtaions<IRelation_Subsidiary_Business>().Select(x => x.business);
            }
        }
    }
}
