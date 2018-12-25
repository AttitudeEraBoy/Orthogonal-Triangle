using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthogonal_Triangle
{
    class Program
    {
        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
        static void Main(string[] args)
        {
            List<int> toplam = new List<int>();
            int sum;
            Console.WriteLine("Enter the amount of rows you want to enter.");
            int rows = Int32.Parse(Console.ReadLine());
            int columns = rows + 1;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(i.ToString() + "row," + j.ToString() + "column. Enter the number you want to enter");
                    array[i, j] = Int32.Parse(Console.ReadLine());
                    if (j == i)
                    {
                        break;
                    }
                }
            }
            toplam.Add(array[0, 0]);
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (IsPrime(array[i, j]))
                    {
                        toplam.Add(array[i, j]);
                        break;
                    }
                    continue;
                }
            }
            sum = toplam.Sum();
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
