using System;
using System.IO;

namespace omlc
{
    class MainClass
    {
        public static int Main(string[] args)
        {
            using (var input = new StreamReader(args[0]))
            using (var output = new StreamWriter(args[1]))
            {
                var oobject = OMLParser.Parse(input);
                // TODO: do something with that
            }
            return 0;
        }
    }
}
