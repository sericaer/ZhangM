using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class Relation_Subsidiary_Business : Relation, IRelation_Subsidiary_Business
    {
        public ISubsidiary subsidiary => entity1 as ISubsidiary;
        public IBusiness business => entity2 as IBusiness;

        public Relation_Subsidiary_Business(ISubsidiary subsidiary, IBusiness business) : base(subsidiary as Entity, business as Entity)
        {

        }

        public override Type GetInterfaceType()
        {
            return typeof(IRelation_Subsidiary_Business);
        }
    }
}
