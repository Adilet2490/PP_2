using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
       public static bool Prime(int n)
        {
            if (n == 0 || n == 1) return false;
             for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
        return true;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (Prime(int.Parse(arr[i])) == true) sum++;
            }
            Console.WriteLine(sum);
            for (int i = 0; i < a; i++)
            {
                if (Prime(int.Parse(arr[i])) == true) Console.Write(arr[i] + " ");
            }
        }
    }
}
