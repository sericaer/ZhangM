using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public class SystemRelationSubsidiaryBusiness
    {
        private RelationManager relationMgr;

        public SystemRelationSubsidiaryBusiness(RelationManager relationMgr)
        {
            this.relationMgr = relationMgr;
        }

        public void SetRelation(ISubsidiary subsidiary, IBusiness business)
        {
            if (business == null)
            {
                throw new Exception();
            }

            if (subsidiary == null)
            {
                relationMgr.RemoveRelations<IRelation_Subsidiary_Business>(x => x.entity2 == business);
                return;
            }

            relationMgr.RemoveRelations<IRelation_Subsidiary_Business>(x => x.entity2 == business);

            relationMgr.AddRelation(new Relation_Subsidiary_Business(subsidiary, business));
        }
    }
}
