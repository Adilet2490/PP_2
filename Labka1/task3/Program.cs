using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static public int[] Array2(int[] arr1, int[] arr2, int arsz)//Функция для заполнения 2 массива 
        {
            for (int i = 0; i < arsz; i++)
            {
                for (int j = i, k = i + arsz; j <= i && k < arsz * 2; j++, k++)
                {
                    arr2[j] = arr1[i];//заполняю массив
                    arr2[k] = arr1[i];//элементами 
                }
            }
            Array.Sort(arr2);//сортирую его 
            return arr2;//возращаю значение 
        }

        static void Main(string[] args)
        {
            int arsz = Convert.ToInt32(Console.ReadLine());//обьявил размер массива 
            string[] arr = Console.ReadLine().Split();//обьявил элементы массива

            int[] arr1 = new int[arsz];//все элементы первого массива будут тут
            int[] arr2 = new int[arsz * 2];//все элементы 2 массива будут тут

            for (int i = 0; i < arsz; i++)
            {
                arr1[i] = int.Parse(arr[i]);//передал все элементы из string arr в string arr1
            }

            arr2 = Array2(arr1, arr2, arsz);//Призвал функцию(13 строка) 
            for (int i = 0; i < arsz * 2; i++)
            {
                Console.Write(arr2[i] + " ");//вывожу все элементы 
            }
        }

    }
}