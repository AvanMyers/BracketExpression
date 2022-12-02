using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openBrecketCount = 0;
            int closedBrecketCount = 0;
            int brecketCountInLine = 0;
            int maxBrecketCount = 0;
            string brecketLine = "";
            char openBrecket = '(';
            char closedBrecket = ')';
            char recordedBrecket = '(';

            Console.WriteLine("Введите скобочное выражение:");
            brecketLine = Console.ReadLine();
            Console.WriteLine($"Строка состоит из {brecketLine}");

            for (int i = 0; i < brecketLine.Length; i++)
            {
                if (brecketLine[0] == closedBrecket)
                {
                    Console.WriteLine("Ошибка");
                    i = brecketLine.Length - 1;
                }
                else
                {
                    if (brecketLine[i] == recordedBrecket)
                    {
                        brecketCountInLine++;
                    }
                    else if (brecketLine[i] == openBrecket || brecketLine[i] == closedBrecket)
                    {
                        recordedBrecket = brecketLine[i];

                        if (brecketCountInLine > maxBrecketCount)
                        {
                            maxBrecketCount = brecketCountInLine;
                            brecketCountInLine = 0;
                        }
                    }

                    if (brecketLine[i] == openBrecket)
                    {
                        openBrecketCount++;
                    }
                    else if (brecketLine[i] == closedBrecket)
                    {
                        closedBrecketCount++;
                    }
                }

                Console.WriteLine($"{openBrecketCount}, {closedBrecketCount}");
            }

            if (openBrecketCount == closedBrecketCount)
            {
                Console.WriteLine($"Данное скобочное выражение является корректным и максимум глубины = {maxBrecketCount}");
            }
            else
            {
                Console.WriteLine("Данное выражение не является корректным.");
            }

            Console.ReadKey();
        }
    }
}
