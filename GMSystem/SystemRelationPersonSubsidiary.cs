using System;

namespace ZhangM
{
    public class SystemRelationPersonSubsidiary
    {
        private RelationManager relationMgr;

        public SystemRelationPersonSubsidiary(RelationManager relationMgr)
        {
            this.relationMgr = relationMgr;
        }

        public void SetRelation(IPerson person, ISubsidiary subsidiary)
        {
            if (person != null)
            {
                relationMgr.RemoveRelations<IRelation_Person_Subsidiary>(x => x.person == person);
            }

            if(subsidiary != null)
            {
                relationMgr.RemoveRelations<IRelation_Person_Subsidiary>(x => x.subsidiary == subsidiary);
            }
            
            if(subsidiary != null && person != null)
            {
                relationMgr.AddRelation(new Relation_Person_Subsidiary(person, subsidiary));
            }
        }
    }
}