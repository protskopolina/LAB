using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
 
    
        static void Main(string[] args)
        {
            string pattern = @"^[0-9a-fA-F]{1,6}$";  // Шістнадцятикове число без нулів
            string[] tString = { "123456", "234567", "1234567", "12345", "0a1f" };

            foreach (var testString in tString)
            {
                if (Regex.IsMatch(testString, pattern))
                {
                    Console.WriteLine($"'{testString}' є шістнадцятиковим числом.");
                }
                else
                {
                    Console.WriteLine($"'{testString}' не є шістнадцятиковим числом.");
                }
            }
        }
    }

}

  

