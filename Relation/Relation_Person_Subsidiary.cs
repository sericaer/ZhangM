using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class Relation_Person_Subsidiary : Relation, IRelation_Person_Subsidiary
    {
        public IPerson person => entity1 as IPerson;
        public ISubsidiary subsidiary => entity2 as ISubsidiary;

        public Relation_Person_Subsidiary(IPerson person, ISubsidiary subsidiary) : base(person as Entity, subsidiary as Entity)
        {

        }

        public override Type GetInterfaceType()
        {
            return typeof(IRelation_Person_Subsidiary);
        }
    }
}
