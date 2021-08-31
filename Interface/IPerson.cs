using System.Collections.Generic;

namespace ZhangM
{
    public interface IPerson
    {
        string fullName { get; }

        int maxBusinessCount { get; }

        int maxGuidanceCount { get; }

        int maxLearningCount { get; }

        int maxSubsidiaryCount { get; }

        ISect sect { get; }

        ISubsidiary currSubsidary { get; }

        ISubsidiary ownedSubsidiary { get; }

        IEnumerable<ISubsidiary> subsidiaries { get; }
    }
}
