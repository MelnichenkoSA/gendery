using System;

namespace gendery
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int N = int.Parse(Console.ReadLine());

                if ((N & (int)ДеньНедели.Вторник) == (int)ДеньНедели.Вторник || (N & (int)ДеньНедели.Среда) == (int)ДеньНедели.Среда)
                    Console.WriteLine("Среда или Вторник");
            }
            
        }
    }
    enum ДеньНедели
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 4,
        Четверг = 8,
        Пятница = 16,
        Суббота = 32,
        Воскресенье = 64

    }

}
