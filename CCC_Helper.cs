using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCC_2023_Setup
{
    public static class CCC_Helper
    {
        private static string GetOutputFilePath(string filePath)
        {
            return $"{Directory.GetCurrentDirectory()}\\output\\{filePath.Split('\\')[^1]}";
        }

        public static void RunAll()
        {
            RunTest();

            foreach (string filePath in Directory.GetFiles($"{Directory.GetCurrentDirectory()}\\input"))
            {
                string[] result = Program.Solution(File.ReadAllLines(filePath));
                File.WriteAllLines(GetOutputFilePath(filePath), result);
            }
        }

        private static void RunTest()
        {
            string testFilePath = $"{Directory.GetCurrentDirectory()}\\test.txt";
            string[] result = Program.Solution(File.ReadAllLines(testFilePath));

            foreach (string line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
