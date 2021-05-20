using System;
using System.Threading.Tasks;

namespace ParserJson
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = "D:\\Lili\\study\\MyProjects GitHub\\ParserJSON\\ParserJson\\Sections.json";
            await Parser.ParserJson(path);
        }
    }
}
