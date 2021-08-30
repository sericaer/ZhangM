
using System.Collections.Generic;


namespace ZhangM
{
    public interface ISect
    {
        IEnumerable<ISubsidiary> subsidiaries { get; }
        IEnumerable<IPerson> persons { get; }
    }
}
