using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface IRelation_Sect_Subsidiary : IRelation
    {
        ISect sect { get; }
        ISubsidiary subsidiary { get; }
    }
}
