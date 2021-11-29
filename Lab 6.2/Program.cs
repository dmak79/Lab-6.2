using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольную фразу");
            string stringBegin = Console.ReadLine();
            stringBegin = stringBegin.ToLower();
            string[] stringArray = stringBegin.Split();
            string bigString = "";
            string probel = " ";
            foreach (string s in stringArray)
            {
                if (s != probel)
                {
                    bigString += s;
                }
            }
            char[] charArray = bigString.ToArray();
            char[] newArray = new char[charArray.Length];
            int n = Convert.ToInt32(bigString.Length);
            for (int i = 0; i < n; i++)
            {
                int j = n - i - 1;
                newArray[i] = charArray[j];
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (charArray[i] != newArray[i])
                {
                    Console.WriteLine("Фраза не является палиндромом");
                    break;
                }
                else
                {
                    Console.WriteLine("Фраза  является палиндромом");
                    break;
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

