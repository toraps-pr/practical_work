using System;

namespace task
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Рандомний масив:");
            // створюємо масив у якому міститься 30 елементів
            int k = 30;
            int [] myarray = new int[k];

            /*заповнюємо масив рандомними значеннями,
            + обмежуємо діапазон значень + виводимо масив*/
            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                myarray[i] = rand.Next(-50, 50);
                Console.Write(myarray[i]+ " ");
            }
            Console.WriteLine();


            //СОРТУВАННЯ БУЛЬБАШКОЮ
            //сорторуємо масив першим способом 
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k - 1; j++)
                {
                    if (myarray[j] > myarray[j + 1])
                    {
                        int t = myarray[j];
                        myarray[j] = myarray[j + 1];
                        myarray[j + 1] = t;

                    }
                }

            }
            //виводимо перший відсорторований масив
            Console.WriteLine();
            Console.WriteLine("Масив вiдсорторований першим способом:");
            for (int i=0; i<k; i++)
            {
                Console.Write(myarray[i] + " ");
            }
            Console.WriteLine();


            //СОРТУВАННЯ ГНОМА
            //сорторуємо масив другим способом 
           
            //l-індекс порівнюваного числа
            int l=1;

            //s-змінна, яку будемо використовувати для обміну
            int s;

            //створюємо змінну, щоб визначити ту точку де ми зупинились і пішли назад
            int nextl=l+1;

            while (l < k)
            {
                //порівнюємо елемент з попереднім
                if (myarray [l-1] < myarray[l])
                {
                    //якщо все нормально переходимо до наступного елемента
                    l=nextl;
                    nextl++;
                }
                //в протилежному випадку міняємо елементи місцями
                else
                {
                    s = myarray[l - 1];
                    myarray[l - 1] = myarray[l];
                    myarray[l] = s;

                    /*повертаємося в зворотньому напрямку щоб перевірити
                    чи не вніс переставлений елемент зміни в уже 
                    відсорторований масив*/
                    l--;

                    /*якщо дійшли до початку масиву, повертаємося до тієї точки 
                    де зупинились і йдемо далі*/
                    if (l == 0)
                    {
                        l = nextl;
                        nextl++;
                    }
                }
            }

            //виводимо відсорторований масив
            Console.WriteLine();
            Console.WriteLine("Масив вiдсорторований другим способом: ");
            for (int i=0; i<k; i++)
            {
                Console.Write(myarray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

