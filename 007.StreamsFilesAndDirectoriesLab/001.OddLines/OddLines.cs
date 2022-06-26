using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFile = @"..\..\..\Files\input.txt";
            string outputFile = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFile, outputFile);
        }

        public static void ExtractOddLines(string inputFile, string outputFile)
        {
            StreamReader reader;
            StreamWriter writer = new StreamWriter(outputFile);
            using (reader = new StreamReader(inputFile))
            {
                int counter = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }

                    line = reader.ReadLine();

                    counter++;
                }

                writer.Flush();
                writer.Close();
            }
        }
    }
}
