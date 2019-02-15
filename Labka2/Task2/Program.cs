using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();//вводим строку
            File.WriteAllText(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\input.txt", s);//записываем ее в файл
            FileStream fs = new FileStream(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\input.txt", FileMode.Open, FileAccess.Read);// файл
            StreamReader sr = new StreamReader(fs);//переводим на понятный язык
            string[] str = sr.ReadToEnd().Split();//передаем все содержание файла в str[]
            sr.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\output.txt", FileMode.Open, FileAccess.Write);//записываем все в output file
            StreamWriter sw = new StreamWriter(fs1);//*
            for (int i = 0; i < str.Length; i++)
            {
                int cnt = 0;//счетчик для простых чисел
                for (int j = 2; j <= Math.Sqrt(int.Parse(str[i])); j++)
                {
                    if (int.Parse(str[i]) % j == 0) cnt++;//ищем все делители числа
                }
                if (cnt == 0 && int.Parse(str[i]) != 1) sw.Write(str[i] + " ");//если выполняется условия то выводим все в файл
            }
            sw.Close();
            fs1.Close();
        }
    }
}

