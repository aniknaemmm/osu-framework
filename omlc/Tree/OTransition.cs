namespace omlc.Tree
{
    public class OTransition
    {
        public OTransition()
        {
            Function = "InOut";
        }

        public string Name { get; set; }
        public OState State { get; set; }
        public double Duration { get; set; }
        public string Function { get; set; }
    }
}