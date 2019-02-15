using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\Labka2\input.txt", s);
            FileStream fs = new FileStream(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\Labka2\input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.Close();
            fs.Close();
            int cnt = 0;
            for(int i = 0,j = s.Length -1; i < s.Length && j >= 0 ; i++,j--)
            {
                if (s[i] == s[j]) cnt++;
            }
            if (cnt == s.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



        }
    }
}
