using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public interface IRelation
    {
        Entity entity1 { get; }
        Entity entity2 { get; }

        Type GetInterfaceType();
    }

    public abstract class Relation : IRelation
    {
        public static IEnumerable<Relation> Emptys = new List<Relation>();

        public Entity entity1 { get; private set; }
        public Entity entity2 { get; private set; }

        public Relation(Entity entity1, Entity entity2)
        {
            this.entity1 = entity1;
            this.entity2 = entity2;
        }

        public abstract Type GetInterfaceType();
    }
}
