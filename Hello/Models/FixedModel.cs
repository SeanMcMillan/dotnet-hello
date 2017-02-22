using System.Collections.Generic;

namespace Hello.Models
{
    public class FixedModel
    {
        private string response = "Hello World";

        public IEnumerable<string> values
        {
            get
            {
                var ret = new List<string>();
                for (var i=0; i < 10; i++) {
                    ret.Add(response);
                }
                return ret;
            }
        }
    }
}