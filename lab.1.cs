using System;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введення значення
            Console.WriteLine("Введiть значення х:");
            string number;
            number = Console.ReadLine();
            //Перетворення типу
            double x = Convert.ToDouble(number);

            Console.WriteLine("Результат обчислень при х=" + x + ":");
            //Оператор умови (в залежності від значення х, визначається як обраховувати  Y)

            double Y;
            if (x < 4)
            {
                Y = (x * x) / 6 + 0.5;
                Console.WriteLine("Y= " + Y);

            }
            else if (x < 10)
            {
                for (int i = 4; i < x; i++)
                {
                    Y = 1;
                    Y = 0.25 * (Y * (i * i * i));
                    Console.WriteLine("Y= " + Y);
                }
            }
            else if (x >= 10)
            {
                for (int i = 10; i <= x; i++)
                {
                    Y = 0;
                    Y = 0.5 * (Y + (3.5 * i));
                    Console.WriteLine("Y= " + Y);
                }
                
            }
            
        }
    }
}
