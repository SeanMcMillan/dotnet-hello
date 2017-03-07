using System.Collections.Generic;

namespace BO.Models
{
    /* In theory, this could be moved into a separate project from the 
    implementation. That's totally not called for here. */
    public interface ListModel
    {
        IEnumerable<string> values { get; }
    }
}