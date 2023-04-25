using System;

namespace task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Заданий масив:");
            // створюємо масив
            int[] myarray = new int[10];

            /*заповнюємо масив рандомними значеннями,
            обмежиши його в діапазоні (-20;20),*/

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                myarray[i] = rand.Next(-20, 20);
                Console.Write(myarray[i] + " ");
            }

            /*Другий по величинi елемент заданого не порожнього масиву рiзних чисел - це другий за рахунком дотатній елемент */

            /*Для наочночті (звісно ж писати та виводити це за умови реальної задачі не потрібно) поступово відсортуруємо масив щоб побачити який елемент нам потрібно вивести*/

            //спочатку відсорторуємо масив за зростанням
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i - 1; j++)
                {
                    if (myarray[j] > myarray[j + 1])
                    {
                        int t = myarray[j];
                        myarray[j] = myarray[j + 1];
                        myarray[j + 1] = t;

                    }
                }
            }
            //та виведемо його
            Console.WriteLine();
            Console.WriteLine("Вiдсорторований масив:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(myarray[i] + " ");
            }
            //звідси ми бачимо скільки у нас є дотатніх елементів і який з них найбільший/найменший


            //виведемо лише ці (дотатні) елементи
            Console.WriteLine();
            Console.WriteLine("Дотатнi елементи:");
            for (int i = 0; i < 10; i++)
            {
                int number = 0;
                if (myarray[i] > number)
                {
                    int j = myarray[i];
                    Console.Write(j + " ");  
                } 
            }
            Console.WriteLine();
            //тепер ми точно бачимо яким у нас має бути результат, і що потрібно вивести


            //створимо простий цикл з умовами для пошуку того самого, необхідного елемента
            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                if (myarray[i] > 0)
                {
                    temp = myarray[i];
                }

            }
            for(int i=0; i<10; i++)
            {
                if (myarray[i] > 0)
                {
                    if (myarray[i] < temp)
                    {
                        temp = myarray[i+1];
                    }
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Немає дотатних чисел!");
            }
            else
            {
                Console.WriteLine("Другий по величинi елемент заданого не порожнього масиву рiзних чисел: " + temp);

            }
            Console.WriteLine();   
        }
    }
}
