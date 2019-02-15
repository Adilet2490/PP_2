using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello!";
            string path2 = @"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\a0.txt";
            StreamWriter file = new StreamWriter(@"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\b.txt");
            file.Write(a);
            file.Close();
            string path = @"C:\Users\Adilet\Documents\Visual Studio 2017\Backup Files\PP_2\Test.txt";
            if (File.Exists(path2))
            //Проверяем есть ли существующий файл, типa, Метод Move нельзя использовать для перезаписи существующего файла.
            //Exists(file): определяет, существует ли файл
            {
                File.Delete(path2);     //Если есть ,то удаляем.
                File.Move(path, path2);    //После файл с path перемещяем в path2
                                           //Move: перемещает файл в новое место

            }
            Console.WriteLine("Created a file in the directory path, then copied it to the directory path1 and the original has deleted");
        }
    }
}