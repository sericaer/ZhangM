using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface ISubsidiary
    {
        ISect sect { get; }

        IPerson owner { get; }

        IEnumerable<IBusiness> businesses { get; }
    }
}
