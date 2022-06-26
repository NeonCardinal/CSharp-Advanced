using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFile = @"..\..\..\Files\input.txt";
            string outputFile = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputFile, outputFile);
        }

        public static void RewriteFileWithLineNumbers(string inputFile, string outputFile)
        {
            StreamReader reader = new StreamReader(inputFile);
            StreamWriter writer = new StreamWriter(outputFile);

            using (reader)
            {
                int lineCounter = 1;
                string line = reader.ReadLine();

                while(line != null)
                {
                    writer.WriteLine(lineCounter + ". " + line);
                    line = reader.ReadLine();
                    lineCounter++;
                }

                //writer.Flush();
                writer.Close();
            }
        }
    }
}
