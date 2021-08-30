using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public class RelationManager
    {
        private Dictionary<Type, List<IRelation>> relationDict = new Dictionary<Type, List<IRelation>>();

        public void AddRelation(Relation relation)
        {
            relation.entity1.AddRelation(relation);
            relation.entity2.AddRelation(relation);

            var type = relation.GetInterfaceType();
            if (!relationDict.ContainsKey(type))
            {
                relationDict.Add(type, new List<IRelation>());
            }

            relationDict[type].Add(relation);
        }

        public void RemoveRelations<T>(Func<T, bool> func) where T : class, IRelation
        {
            List<IRelation> relations;
            if (!relationDict.TryGetValue(typeof(T), out relations))
            {
                return;
            }

            var needRemove = relations.Where(x => func((T)x)).ToArray();
            foreach (var relation in needRemove)
            {
                relation.entity1.RemoveRelation(relation);
                relation.entity2.RemoveRelation(relation);

                relationDict[typeof(T)].Remove(relation);
            }
        }
    }
}
