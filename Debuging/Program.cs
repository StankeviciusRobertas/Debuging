using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Debuging
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            //GetFullName("Robertas", "Stankevicius");

            //int a = 4;
            //int b = 5;
            //int c = 8;

            //int max = a;
            //if (b > max)
            //    max = b;
            //if (c > max)
            //    max = c; // cia buvo klaida

            //Console.WriteLine("The maximum valuse is: " + max);

            //string firstName = "John";
            //string lastName = "Doe";
            //string fullName = firstName + " " + lastName; //klaida 
            //Console.WriteLine("Full name: " + fullName);

            //int counter = 1;

            //while (counter <= 10)
            //{
            //    Console.WriteLine("Count: " + counter);
            //    counter++;
            //}

            //int i = 1;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //string name1 = "John";
            //string name2 = "john";

            //if (name1.Equals(name2))
            //{
            //    Console.WriteLine("Names are the same");
            //}
            //else
            //{
            //    Console.WriteLine("names are different.");
            //}

            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.Append("Labas, ");
            //stringBuilder.Append("kaip sekasi? ");
            //stringBuilder.Append("Tikiuosi, kad viskas gerai!");

            //string result = stringBuilder.ToString();

            //Console.WriteLine(result);

            //string text = "";
            //int iterations = 10000;

            ////Pirmasis scenarijus: tiesiogines "string" manipuliacija
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "A";
            //}

            //stopwatch.Stop();
            //TimeSpan elapsedStringManipulation = stopwatch.Elapsed;

            ////Antrasis scenarijus: "StringBuilder" naudojimas
            //stopwatch.Restart();
            //stopwatch.Start();

            //StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i < iterations; i++)
            //{
            //    stringBuilder.Append("A");
            //    //Console.WriteLine(stringBuilder);
            //}
            //string result = stringBuilder.ToString();

            //stopwatch.Stop();
            //TimeSpan elapsedStringBuilder = stopwatch.Elapsed;

            ////Isvesti rezultatai
            //Console.WriteLine("Tiesiogines 'string' manipuliacijos: " + elapsedStringManipulation);
            //Console.WriteLine("Naudojant 'StringBuilder': " + elapsedStringBuilder);


            //Console.WriteLine("Iveskit savo teksta as ji apversiu ");
            //string str = Console.ReadLine();
            //string reverse = str.reverse();
            //Console.WriteLine(reverse);

            Console.WriteLine("Iveskit teksta: ");
            string text = Console.ReadLine();
            string result = RemoveDublicats(text);
            
            Console.WriteLine(result);

         }

        public static string RemoveDublicats(string text)
        {
            StringBuilder sb = new StringBuilder();
             string resultString = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (!resultString.Contains(text[i].ToString()))
                {
                    resultString += text[i];
                }                
            }            
            return resultString;
        }

        public static string reverse(this string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(str[i]);
            }
            return stringBuilder.ToString();
        }

        public static string GetFullName(string firstName, string lastName)
        {
            Console.WriteLine($"Registruotas naudotojas yra: {firstName} {lastName}");
            PrintDanger("niekas niekur neina");
            return firstName.Trim() + " " + lastName.Trim();
        }

        public static void PrintDanger(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}