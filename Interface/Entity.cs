using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZhangM
{
    public abstract class Entity
    {
        protected Dictionary<Type, List<IComponent>> componentDict = new Dictionary<Type, List<IComponent>>();

        protected Dictionary<Type, List<IRelation>> relationDict = new Dictionary<Type, List<IRelation>>();

        public void AddComponent(IComponent component)
        {
            var type = component.GetInterfaceType();
            if (!componentDict.ContainsKey(type))
            {
                componentDict.Add(type, new List<IComponent>());
            }

            componentDict[type].Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRealtaions<T>() where T : class, IRelation
        {
            List<IRelation> relations;
            if (relationDict.TryGetValue(typeof(T), out relations))
            {
                return relations.Select(x => x as T);
            }

            return Relation.Emptys.Select(x => x as T);
        }

        public void AddRelation(IRelation relation)
        {
            if (relation.entity1 != this && relation.entity2 != this)
            {
                throw new Exception();
            }

            var type = relation.GetInterfaceType();
            if (!relationDict.ContainsKey(type))
            {
                relationDict.Add(type, new List<IRelation>());
            }

            relationDict[type].Add(relation);
        }

        public void RemoveRelation(IRelation relation)
        {
            var type = relation.GetInterfaceType();
            if (relationDict.ContainsKey(type))
            {
                relationDict[type].Remove(relation);
            }
        }
    }
}
