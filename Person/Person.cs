using System;
using System.Collections.Generic;
using System.Linq;

namespace ZhangM
{
    public class Person : Entity, IPerson
    {

        public int maxBusinessCount { get; private set; }

        public int maxGuidanceCount { get; private set; }

        public int maxLearningCount { get; private set; }

        public int maxSubsidiaryCount { get; private set; }

        public ISect sect
        {
            get
            {
                return currSubsidary == null ? null : currSubsidary.sect;
            }
        }

        public ISubsidiary currSubsidary => ownedSubsidiary;

        public ISubsidiary ownedSubsidiary
        {
            get
            {
                var relation = GetRealtaions<IRelation_Person_Subsidiary>().SingleOrDefault();
                return relation == null ? null : relation.subsidiary;
            }
        }

        public IEnumerable<ISubsidiary> subsidiaries => throw new NotImplementedException();

        public Person()
        {
            maxBusinessCount = 3;
            maxGuidanceCount = 5;
            maxLearningCount = 1;
            maxSubsidiaryCount = 5;
        }
    }
}
