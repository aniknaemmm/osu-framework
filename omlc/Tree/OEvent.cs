using System.Collections.Generic;

namespace omlc.Tree
{
    public class OEvent
    {
        public string Name { get; set; }
        public List<OTransition> Transitions { get; set; }
    }
}