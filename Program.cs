namespace CCC_2023_Setup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CCC_Helper.RunAll();
        }

        public static string[] Solution(string[] input)
        {
            List<string> output = new List<string>();

            output.Add(input[0]);

            return output.ToArray();
        }
    }
}