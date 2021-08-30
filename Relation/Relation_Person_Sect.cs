//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ZhangM
//{
//    public class Relation_Person_Sect : Relation, IRelation_Person_Sect
//    {
//        public IPerson person => entity1 as IPerson;
//        public ISect sect => entity2 as ISect;

//        public Relation_Person_Sect(IPerson person, ISect sect) : base(person as Entity, sect as Entity)
//        {

//        }

//        public override Type GetInterfaceType()
//        {
//            return typeof(IRelation_Person_Sect);
//        }
//    }
//}
