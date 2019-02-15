using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        public static void Level(int level) //считывает все табуляций и выводит их
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
        }

        public static void Tree(DirectoryInfo dir, int level)
        {                                                    //
            foreach (FileInfo fi in dir.GetFiles())          //
            {                                               ////если элементы папки -> файлы то выводим их
                Level(level);                               ///
                Console.WriteLine(fi.Name);///////////////////
            }
            foreach (DirectoryInfo di in dir.GetDirectories())/////  если элемент папки ->папка то выводим и призываем метод с этой папкой в значений
            {                                                   // 
                Level(level);                                   ////
                Console.WriteLine(di.Name);                     ///
                Tree(di, level + 1);//////////////////////////////
            }

        }
    }
}