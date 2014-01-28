using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KotusFinnishWordListParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            StreamReader reader = new StreamReader(fileName);

            List<string> lines = new List<string>();

            string line = "";
            while ((line = reader.ReadLine()) != null)
            {

                if (line.Contains("<tn>"))
                    continue;

                line = line.Replace("<st><s>", "").Replace("</s></st>","");

                lines.Add(line);
            }


            StreamWriter writer = new StreamWriter("output.txt");

            string stuff = String.Join("\n", lines);

            writer.Write(stuff);

        }
    }
}
