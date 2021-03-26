using System;

namespace методы_и_области_видимости_переменных
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Console.WriteLine(x);
            //int x2 = Double(x);
            //Console.WriteLine(x2);

            //static int Double(int x)
            //{
            //    x = x * 2;
            //    return x;
            //}

            /// <summary>
            /// Найти минимальный элемент массива
            /// </summary>

            //    int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            //int min = a[0];
            //for (int i = 1; i < a.Length; i++)
            //{
            //    if (a[i]<min)
            //    {
            //        min = a[i];
            //    }

            //}
            //Console.WriteLine(min);    
            //Console.ReadLine();


            ///// <summary>
            ///// Найти два наибольших элемента массива
            ///// </summary>

            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            //int max, max2;
            //max = max2 = a[0];




            //for (int i = 1; i < a.Length; i++)
            //{
            //    if (a[i] > max)
            //    {
            //        max2 = max;
            //         max = a[i];
            //    }
            //    else if (a[i] > max2)
            //    {
            //        max2 = a[i];
            //    }

            //}        
            //Console.WriteLine(max);
            //Console.WriteLine(max2);
            //Console.ReadLine();

            ///// <summary>
            ///// Посчитать сумму элементов массива
            ///// </summary>

            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            //int dlina = 0;

            //foreach (var item in a)
            //{
            //    dlina =dlina+item;
            //}
            //Console.WriteLine(dlina);


            ///// <summary>
            ///// Заполнить массив по возрастанию от 1 до 100
            ///// </summary>

            //var a = new int[101];
            //for (int i = 1; i < a.Length; i++)
            //{
            //    

            //    Console.WriteLine(i);


            //}
            //Console.ReadLine();

            /// <summary>
            /// Создать и заполнить массив случайными целыми числами
            /// </summary>

            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            //Random rnd = new Random();
            //int r = rnd.Next(1, 10);//случайное число от 1 до 10
            //var a = new int[10];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = rnd.Next(1,10);
            //    Console.WriteLine(a[i]);

            //}
            //Console.ReadLine();




            /// < summary >
            /// Проверить, что в массиве нет одинаковых чисел
            /// </ summary >

            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6, 12 };

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 0; j < a.Length; j++)
            //    {
            //        if (a[i] == a[j] && i != j)
            //        {
            //            Console.WriteLine("повтор");
            //            break;
            //        }

            //    }

            //}





            /// <summary>
            /// Переставить элементы массива в обратном порядке используя вспомогательный массив
            /// </summary>

            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };






            /// <summary>
            /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
            /// </summary>

            //int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            //for (int i = a.Length; i > 0; i--)
            //{
            //    Console.WriteLine(a[i-1]);
            //}

            //вариант 2
            //System.Array.Reverse(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            /// <summary>
            /// Подсчитать сумму чисел в двухмерном массиве
            /// </summary>


            //    int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            //int dlina = 0;
            //foreach (var i in m)
            //{
            //    dlina += i;
            //    Console.WriteLine(dlina);
            //}


            /// <summary>
            /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
            /// </summary>
            //var m = new int[10, 10];
            //Random rnd = new Random();



            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        m[i, j] = rnd.Next(1, 10);
            //        Console.Write(m[i, j]);

            //    }
            //    Console.WriteLine();



            //}


            /// <summary>
            /// Двумерный массив скопировать в одномерный
            /// </summary>

            //int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            //int z = 0;
            //int[] a = new int[m.Length];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        a[z] = m[i, j];
            //    Console.WriteLine(a[z]);
            //    z++;
            //    }
            //}
            //Console.ReadLine();

            /////2 вариант
            //int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            //int rows = m.GetUpperBound(0) + 1;
            //int columns = m.Length / rows;
            //int z = 0;
            //int[] a = new int[m.Length];

            //foreach (int i in m)
            //{
            //    a[z] = i;
            //    Console.WriteLine(a[z]);
            //    z++;
            //}




            /// <summary>
            /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
            /// </summary>

            //подсказка: для определения остатка от деления используется оператор %
            //int ostatok = 4 % 2; //будет равен нулю

            //int sum = 0;
            //var a = new int[10, 10];
            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{

            //    for (int j = 0; j < 10; j++)
            //    {
            //        a[i, j] = rnd.Next(1, 99);
            //        if (a[i, j] % 2 == 0)
            //        {
            //            sum++;

            //        }



            //    }
            //}

            //Console.WriteLine(sum);

         
        }
    }
    }
