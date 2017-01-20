#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
// DO NOT CHANGE
namespace NumberSystemConverter
{
    class Program
    {
        static RomanNumeralConverter converter;

        static void Main(string[] args)
        {
            converter = new RomanNumeralConverter();
            Run();
        }
        
        static void Run()
        {
            #region Runs the program expecting only integral inputs and calls ConvertToRomanNumeral() upon receiving
            while (true)
            {
                int result;
                Console.WriteLine("Numeral Registry");
                Console.WriteLine("Acceptable Values     |     Non-Acceptable Values");
                Console.WriteLine("M - 1000              |     (D, L, I, X, V) + M");
                Console.WriteLine("D - 500               |     (L, X, V, I) + D");
                Console.WriteLine("C - 100               |     (L, V, I) + C");
                Console.WriteLine("L - 50                |     (V, I) + L");
                Console.WriteLine("X - 10                |     ");      
                Console.WriteLine("V - 5                 |     ");
                Console.WriteLine("I - 1                 |     (I) + I + I + I + I\n");

                Console.WriteLine("Please enter an integer value OR roman numeral to be converted...");
                string userInput = Console.ReadLine();
                string[] eiwa = { "DM" , "LM", "IM", "XM", "VM" , "LD", "XD" , "VD", "ID", "LC", "VC", "IC", "VL" , "IL", "IIII" };


                if (userInput.All(c => c >= '0' && c <= '9') && userInput != "") {
                    Console.WriteLine(userInput + " = " + converter.ConvertToRomanNumeral(int.Parse(userInput)));
                } else if (userInput.All(c => c == 'M' || c == 'D' || c == 'C' || c == 'L' || c == 'X' || c == 'V' || c == 'I') &&
                          !eiwa.Any(c => userInput.Contains(c)))
                {
                    Console.WriteLine(userInput + " = " + converter.ConvertFromRomanNumeral(userInput.ToCharArray().Select(c => c.ToString()).ToArray()));
                }
                else
                {
                    Console.WriteLine(userInput + " Invalid Input");
                }
                Console.Write("\nPress any key...");
                Console.ReadKey();
                Console.Clear();
            }
            #endregion
        }
    }
}
