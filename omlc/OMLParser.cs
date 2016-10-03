using System.IO;
using YamlDotNet;
using omlc.Tree;
using YamlDotNet.RepresentationModel;

namespace omlc
{
    public static class OMLParser
    {
        public static OObject Parse(StreamReader stream)
        {
            var result = new OObject();
            var yaml = new YamlStream();
            yaml.Load(stream);
            var root = (YamlMappingNode)yaml.Documents[0].RootNode;
            System.Console.WriteLine(root);
            return result;
        }
    }
}