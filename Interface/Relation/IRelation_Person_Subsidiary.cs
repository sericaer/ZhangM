using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface IRelation_Person_Subsidiary : IRelation
    {
        IPerson person { get; }
        ISubsidiary subsidiary { get; }
    }
}
