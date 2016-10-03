using System.Collections.Generic;

namespace omlc.Tree
{
    public class OObject
    {
        public OObject()
        {
            Extends = "Drawable";
            DefaultValues = new Dictionary<string, string>();
            States = new Dictionary<string, OState>();
            Transitions = new Dictionary<string, OTransition>();
            Events = new Dictionary<string, OEvent>();
            Properties = new Dictionary<string, OProperty>();
            Children = new List<OObject>();
        }

        public string Extends { get; set; }
        public Dictionary<string, string> DefaultValues { get; set; }
        public Dictionary<string, OState> States { get; set; }
        public Dictionary<string, OTransition> Transitions { get; set; }
        public Dictionary<string, OEvent> Events { get; set; }
        public Dictionary<string, OProperty> Properties { get; set; }
        public List<OObject> Children { get; set; }
    }
}