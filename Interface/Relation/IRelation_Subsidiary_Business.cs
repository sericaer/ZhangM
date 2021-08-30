using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface IRelation_Subsidiary_Business : IRelation
    {
        ISubsidiary subsidiary { get; }
        IBusiness business { get; }
    }
}
