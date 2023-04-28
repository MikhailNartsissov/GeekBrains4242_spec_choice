using Microsoft.VisualBasic;
using System;
using System.Reflection;


namespace GeekBrains4242_spec_choice
{
    internal class GeekBrains4242_final_work
    {
        //Метод отбора элементов, короче четырех символов из массива
        private static string[] LessThanFour(string[] farr) 
        {
            string[] fresult = new string[farr.Length];
            int rindex = 0;
            for (int findex = 0; findex < farr.Length; findex++)
            {
                if (farr[findex].Length <= 3)
                {
                    fresult[rindex] = farr[findex];
                    rindex++;
                }
            }
            return fresult;
        }

        private static void PrintArray(string[] farray)            
        {
            int flength = farray.Length - 1;
            Console.Write("[");
            for (int findex = 0; findex < flength; findex++)
            {
                if (farray[findex + 1] != null)
                {
                    Console.Write($"{farray[findex]}, ");
                }
                else 
                {
                    Console.Write($"{farray[findex]}]\n");
                    break;
                }
            }
            if (farray[flength] != null) 
            {
                Console.Write($"{farray[flength]}]\n");
            }
        }

        private static string[] AskAndFill()
        {
            Console.WriteLine("\nВведите элементы исходного массива через запятую:");
            string[] fuserArray = Console.ReadLine().Split(',').Select(x => x.ToString().Trim()).ToArray();
            return (fuserArray);
        }

        public static void Main()
        {
            string[] initialArray = AskAndFill();
            string[] resultArray = LessThanFour(initialArray);
            Console.WriteLine("\nИсходный массив:");
            PrintArray(initialArray);
            Console.WriteLine("\nМассив с элементами короче четырёх символов:");
            PrintArray(resultArray);
        }
    }
}
