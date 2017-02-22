using System.Collections.Generic;
using System.Linq;

namespace Hello.Models
{
    public class FixedModel
    {
        private string response = "Hello World";

        public IEnumerable<string> values
        {
            get
            {
                IEnumerable<string> ret = new List<string>();
                for (var i=0; i < 10; i++) {
                    ret.Append(response);
                }
                return ret;
            }
        }
    }
}