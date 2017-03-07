using System.Collections.Generic;

namespace Hello.Models
{

    public interface ListModel
    {
        IEnumerable<string> values { get; }
    }
}