using System;
using System.Threading.Tasks;

namespace ParserJson
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "Sections.json";
            await Parser.ParserJson(path);
        }
    }
}
