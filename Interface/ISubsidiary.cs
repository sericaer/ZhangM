using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface ISubsidiary
    {
        string name { get; }

        ISect sect { get; }

        IPerson owner { get; }

        IEnumerable<IBusiness> businesses { get; }
    }
}
