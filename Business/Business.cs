using System;
using System.Linq;

namespace ZhangM
{
    public class Business : Entity, IBusiness
    {
        public ISubsidiary subsidiary
        {
            get
            {
                var relation = GetRealtaions<IRelation_Subsidiary_Business>().SingleOrDefault();
                if (relation == null)
                {
                    return null;
                }

                return relation.subsidiary;
            }
        }

        public int efficiency
        {
            get
            {
                var rslt = subsidiary.businesses.Count() * 100 / subsidiary.owner.maxBusinessCount;
                return rslt > 100 ? 100 : rslt;
            }
        }
    }
}
