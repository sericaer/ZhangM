using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public interface IComponentProductor : IComponent
    {
        ICondition condition { get; }
        IProduct pdt { get; }
    }

    public interface ICondition
    {
        bool isTrue();
    }
}
