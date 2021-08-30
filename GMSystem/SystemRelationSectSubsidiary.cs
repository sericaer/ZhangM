using System;

namespace ZhangM
{
    public class SystemRelationSectSubsidiary
    {
        private RelationManager relationMgr;

        public SystemRelationSectSubsidiary(RelationManager relationMgr)
        {
            this.relationMgr = relationMgr;
        }

        public void SetRelation(ISect sect, ISubsidiary subsidiary)
        {
            if (subsidiary == null)
            {
                throw new Exception();
            }

            if (sect == null)
            {
                throw new Exception();
            }

            relationMgr.RemoveRelations<IRelation_Sect_Subsidiary>(x => x.subsidiary == subsidiary);

            relationMgr.AddRelation(new Relation_Sect_Subsidiary(sect, subsidiary));
        }
    }
}