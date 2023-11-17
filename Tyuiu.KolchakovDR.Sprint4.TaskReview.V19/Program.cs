using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint4.TaskReview.V19.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint4.TaskReview.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
            4,
            "Колчаков Д. Р.",
            "ИИПб-23-2",
            "Задание по спринту (SprintReview)",
            7,
            19,
            "Дана строка из одноразрядных цифр \"90817264\". Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.");
            thg.printHeader();

            int n = 4;
            int m = 2;
            int[,] matrix = new int[n, m];

            string str = "90817264";

            int index = 0;

            Console.WriteLine("\vМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($" {str[index]}   ");
                    index++;
                }
                Console.WriteLine();
            }

            thg.printFooter();

            Console.Write("Количество нечетных чисел: " + ds.Calculate(n, m, str));
            Console.ReadLine();
        }
    }
}
