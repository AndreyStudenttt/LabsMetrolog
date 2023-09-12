using System;

namespace Lab1Cons
{
    /*
    Задание
    h - кол яч в масиве (16,32,64...) , заполняются от 1 до 100 рандомом
    находиться H-сумма ячеек, повторяется процес несколько раз (M) и находится среднее
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер словаря:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Объем выберки :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квантиль:");
            int q = Convert.ToInt32(Console.ReadLine());

            int[] dir = new int[h];
            Random r = new Random();
            int argvol = 0;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < dir.Length; i++)
                {
                    dir[i] = r.Next(1, 100);
                    argvol += dir[i];
                }
            }
           
            //for (int i = 0; i < dir.Length; i++)
            //{
            //    Console.WriteLine(dir[i]);
            //}
        }
       
    }
}
