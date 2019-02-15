using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{
    class Program
    {
        public static bool Prime(int x)
        {
            if (x == 1 || x == 0) return false;
            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\Labka2\input.txt", s);
            FileStream fs = new FileStream(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\Labka2\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] s1 = sr.ReadLine().Split();

            sr.Close();x`
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\Labka2\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            for (int i = 0; i < s1.Length; i++)
            {
                if (Prime(int.Parse(s1[i])) == true)  sw.WriteLine("Yes"); 
                else sw.WriteLine("No");
            }                                                                                                                                                                                                                                                                    
            sw.Close();
            fs1.Close();
        
        }
    }
}
