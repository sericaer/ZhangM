using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class Relation_Sect_Subsidiary : Relation, IRelation_Sect_Subsidiary
    {

        public ISect sect => entity1 as ISect;

        public ISubsidiary subsidiary => entity2 as ISubsidiary;

        public Relation_Sect_Subsidiary(ISect sect, ISubsidiary subsidiary) : base(sect as Entity, subsidiary as Entity)
        {

        }

        public override Type GetInterfaceType()
        {
            return typeof(IRelation_Sect_Subsidiary);
        }
    }
}
