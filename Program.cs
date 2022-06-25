using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Кузьмина Юлия
// Домашняя работа 4
namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление массива длинной 20 элементов с минимальным и максимальным значениями 
            MyArray myArray = new MyArray(20, -10000, 10000);
            Console.WriteLine(myArray.ToString());
            myArray.Divisibility3();
            Console.ReadLine();
        }
    }


    public class MyArray
    {
        //Приватное поле-массив класса Array 
        private int[] am;


        //Конструктор массива с заполением случаяными числами 
        public MyArray(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);
        }

        //Метод подсчета пар чисел, которые делятся на 3
        public int Divisibility3()
        {
            int count = 0;
            foreach (int x in am)
            {
                if (am[x] % 3 == 0 | am[x + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", am[x], am[x + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }

        //Метод вывода массива на консоль
        override public string ToString()
        {
            string stringarray = "";
            foreach (int x in am)
                stringarray = stringarray + x + " ";
            return stringarray;
        }
    }





}