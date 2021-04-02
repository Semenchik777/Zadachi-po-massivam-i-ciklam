using System;

namespace методы_и_области_видимости_переменных
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadacha01();
        }

        public static void Zadacha01()
        {
            int x = 10;
            Console.WriteLine(x);
            int x2 = Double(x);
            Console.WriteLine(x2);
        }

        public static int Double(int x)
        {
            x = x * 2;
            return x;
        }


        public static void Zadacha1()
        {
            /// <summary>
            /// Найти минимальный элемент массива
            /// </ summary >

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }

            }
            Console.WriteLine(min);
            Console.ReadLine();
        }

        public static void Zadacha2()
        {
            ///// <summary>
            ///// Найти два наибольших элемента массива
            ///// </summary>

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int max = a[0];
            int max2 = a[1];

            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max2 = max;
                    max = a[i];
                }
                if (max2 < a[i] && a[i] != max)
                {
                    max2 = a[i];
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(max2);
            Console.ReadLine();
        }


        public static void Zadacha3()
        {
            ///// <summary>
            ///// Посчитать сумму элементов массива
            ///// </summary>

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int dlina = 0;

            foreach (var item in a)
            {
                dlina = dlina + item;
            }
            Console.WriteLine(dlina);
        }

        public static void Zadacha4()
        {
            ///// <summary>
            ///// Заполнить массив по возрастанию от 1 до 100
            ///// </summary>

            var a = new int[100];
            for (int i = 1; i <= a.Length; i++)
            {


                Console.WriteLine(i);


            }
            Console.ReadLine();
        }

        public static void Zadacha5()
        {
            /// <summary>
            /// Создать и заполнить массив случайными целыми числами
            /// </summary>

            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();
            int r = rnd.Next(1, 10);//случайное число от 1 до 10
            var a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 10);
                Console.WriteLine(a[i]);

            }
            Console.ReadLine();
        }

        public static void Zadacha6()
        {

            /// < summary >
            /// Проверить, что в массиве нет одинаковых чисел
            /// </ summary >

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6, 12 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] && i != j)
                    {
                        Console.WriteLine("повтор");
                        break;
                    }

                }

            }
        }

        public static void Zadacha7()
        {
            /// <summary>
            /// Переставить элементы массива в обратном порядке используя вспомогательный массив
            /// </summary>

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - i - 1] = a[i];


            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

        }
        public static void Zadacha7_0()
        {
            //Лист + сортировка
            int[] list = { -71, 9, 6, -3, 43, 8, 10, 12, 14, 3, 9, 5, 791 };
            Array.Sort(list);
            int max1 = list[list.Length - 1];
            int max2 = list[list.Length - 2];
            Console.WriteLine(max1);
            Console.WriteLine(max2);
        }
        public static void Zadacha7_1()
        {
            //Сортировка + в обратнмо порядке не использую массив
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            Array.Sort(a);
            for (int i = a.Length; i > 0; i--)
            {
                Console.WriteLine(a[i - 1]);

            }
        }

        public static void Zadacha8()
        {
            /// <summary>
            /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
            /// </summary>

            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            for (int i = a.Length; i > 0; i--)
            {
                Console.WriteLine(a[i - 1]);
            }
        }
        public static void Zadacha8_1()
        {
            //вариант 2
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static void Zadacha9()
        {
            /// <summary>
            /// Подсчитать сумму чисел в двухмерном массиве
            /// </summary>


            //int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            //int dlina = 0;
            //foreach (var i in m)
            //{
            //    dlina = dlina + i;

            //}
            //Console.WriteLine(dlina);
        }

        public static void Zadacha10()
        {
            /// <summary>
            /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
            /// </summary>
            var m = new int[10, 10];
            Random rnd = new Random();



            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    m[i, j] = rnd.Next(1, 10);
                    Console.Write($"{m[i, j]}\t");

                }
                Console.WriteLine();
            }

        }

        public static void Zadacha11()
        {
            /// <summary>
            /// Двумерный массив скопировать в одномерный
            /// </summary>

            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int z = 0;
            int[] a = new int[m.Length];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[z] = m[i, j];
                    Console.Write($"{a[z]}\t");
                    z++;
                }
            }
            Console.ReadLine();
        }

        public static void Zadacha11_1()
        {

            /////2 вариант
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int rows = m.GetUpperBound(0) + 1;
            int columns = m.Length / rows;
            int z = 0;
            int[] a = new int[m.Length];

            foreach (int i in m)
            {
                a[z] = i;
                Console.WriteLine(a[z]);
                z++;
            }
        }

        public static void Zadacha12()
        {
            /// <summary>
            /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
            /// </summary>

            //подсказка: для определения остатка от деления используется оператор %
            //int ostatok = 4 % 2; //будет равен нулю

            int sum = 0;
            var a = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = rnd.Next(1, 99);
                    if (a[i, j] % 2 == 0)
                    {
                        sum++;

                    }



                }
            }

            Console.WriteLine(sum);
        }

        public static void Zadacha13()
        {

            /// <summary>
            /// Одномерный массив скопировать в двумерный 4 на 4
            /// </summary>
            int[] a = new int[] { 11, 22, 31, 4, 53, 6, 7, 81, 90, 11, 22, 31, 4, 53, 12, 7 };
            int[,] b = new int[4, 4];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[i, j] = a[k];
                    k++;
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine();
            }
        }




    }
}
    
