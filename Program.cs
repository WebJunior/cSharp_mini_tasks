using System;

namespace MiniTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
        }
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
                
            }
            Console.WriteLine($"Минимальный элемент это {min}");
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 777, 233, 999, 2, 1, 9, 2313, 19, 6 };
            int tempVar;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] >a[j])
                    {
                        tempVar = a[i];
                        a[i] = a[j];
                        a[j] = tempVar;
                    }
                }
            }
            Console.WriteLine($"Максимальный элемент это {a[^1]} и {a[^2]}");
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int summa = 0;
            for (int i = 0; i < a.Length; i++)
            {
                summa += a[i];
            }
            Console.WriteLine($"Сумма элементов = {summa}");
        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] a = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
                Console.WriteLine(a[i]);
            }
        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            int[] a = new int[25];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                int r = rnd.Next(-100, 100);
                a[i] = r;
                Console.WriteLine(a[i]);
            }
            
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] a = new int[] { 5, 12, 13, 13, 1, 9, 15, 19, 13 };
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j]) Console.WriteLine($"Обнаружены одинаковые числа {a[i]} и {a[j]}. Индексы {i} и {j}");
                }
            }
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];

            Console.WriteLine("Начальный массив");
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write($"{a[k]} \t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Перевернутый массив");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[i] = a[i];
                Console.Write($"{b[i]} \t");
            }

        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int tempVar;

            Console.WriteLine("Начальный массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} \t");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < a.Length / 2; i++)
            {
                tempVar = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = tempVar;
            }

            Console.WriteLine("Перевернутый массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} \t");
            }
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31, 4 }, { 4, 53, 6, 354 }, { 7, 81, 90, 7 } };
            int summa = 0;

            foreach (int i in m)
            {
                summa += i;
            }

            Console.WriteLine($"Сумма через цикл foreach {summa}");

            summa = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    summa += m[i, j];
                }
            }

            Console.WriteLine($"Сумма через цикл for {summa}");
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
            int[,] arr = new int[10,10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(1, 9);
                }
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int[] myArr = new int[m.Length];
            int k = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    myArr[k] = m[i, j];
                    k++;
                }
            }

            foreach (int i in myArr)
            {
                Console.WriteLine(i);
            }
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных и нечетных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            int n = 10;
            int m = 10;
            int[,] myArr = new int[n, m];
            Random rnd = new Random();
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArr[i, j] = rnd.Next(1, 99);
                    if (myArr[i, j] % 2 == 0)
                    {
                        evenCount++;
                    } else
                    {
                        oddCount++;
                    }
                }
            }

            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    Console.Write($"{myArr[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Кол-во четных элементов {evenCount}");
            Console.WriteLine($"Кол-во нечетных элементов {oddCount}");
        }
    }
}
