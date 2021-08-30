//using System;

//namespace ZhangM
//{
//    public class SystemRelationPersonSect
//    {
//        private RelationManager relationMgr;

//        public SystemRelationPersonSect(RelationManager relationMgr)
//        {
//            this.relationMgr = relationMgr;
//        }

//        public void SetRelation(IPerson person, ISect sect)
//        {
//            if (person == null)
//            {
//                throw new Exception();
//            }

//            if (sect == null)
//            {
//                relationMgr.RemoveRelations<IRelation_Person_Sect>(x => x.person == person);
//                return;
//            }

//            relationMgr.RemoveRelations<IRelation_Person_Sect>(x => x.person == person);

//            relationMgr.AddRelation(new Relation_Person_Sect(person, sect));
//        }
//    }
//}