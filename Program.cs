using System;
using System.Text;
using System.Linq;

namespace лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //неявное приведение
            byte b = 100;
            int i = b;
            short sh = b;
            float f = i;
            long l = b;
            double d = b;

            // явное приведение
            sbyte sb = 100;
            ushort ush = (UInt16)sb;
            char ch = (Char)sb;
            double d2 = (Double)sb;
            decimal dem = (Decimal)sb;
            int i2 = (Int32)sb;

            bool flag;
            string str;
            object obj;

            //Упаковка и распаковка значимых типов
            int x = 10;
            Object o1 = x;
            byte m1 = (byte)(int)o1;

            short x1 = 25;
            Object o2 = x1;
            int m2 = (int)(short)o2;

            int x3 = 123;
            Object o3 = x3;
            char m3 = (char)(int)o3;

            // Работа с неявно типизированной переменной
            Console.WriteLine("\nРабота с неявно типизированной переменной:");
            var h = 5;
            var a = 12;
            var S = (a * h) / 2;
            Console.Write("Площадь треугольник с высотой " + h + " и основанием " + a + " равна " + S);
            //Работа с Nulleable
            int? z1 = 5;
            int? z2 = null;
            int? z3 = z1 + z2;

            Console.WriteLine("\n" + z1.Value);
            Console.WriteLine(z2.HasValue);
            Console.WriteLine(z3);
            //Console.WriteLine(z3.Value);

            //Объявление и сравнение строковых литералов
            Console.WriteLine("\nОбъявление и сравнение строковых литералов:");
            Console.WriteLine("Hello world!!!");
            string s1 = "hello";
            string s2 = "world";

            int result = String.Compare(s1, s2);
            Console.WriteLine("Результат сравнения строк: " + result);

            string s3 = "hello";
            string s4 = "hello";

            int result1 = String.Compare(s3, s4);
            Console.WriteLine("Результат сравнения строк: " + result1);

            // Основные операции
            //Сцепление
            Console.WriteLine("\nСцепление:");
            string str1 = "hello";
            string str2 = "world";
            string str3 = s1 + " " + s2;
            string str4 = String.Concat(str1, str2);
            Console.WriteLine(str3 + "\n" + str4);
            //
            Console.WriteLine("\nКопирование:");
            string strA = "Have a good day";
            string strB = string.Copy(strA);
            Console.WriteLine(strB);
            //
            Console.WriteLine("\nВыделение подсторки:");
            string s15 = "Привет мир!";
            string s16 = s15.Substring(2);
            string s17 = s15.Substring(4, 4);
            Console.WriteLine(s16);
            Console.WriteLine(s17);
            //Разделение строки на слова
            Console.WriteLine("\nРазделение строки на слова:");
            string s14 = "Строка для разделения";
            string[] res = s14.Split(' ');

            foreach (string s in res)
            {
                Console.WriteLine("\n" + s);
            }
            //вставка подстроки в заданную позицию
            Console.WriteLine("\nВставка подстроки в заданную позицию:");
            string s11 = "Исходная строка для втавки подстроки";
            string s12 = " |Подстрока, которую вставили|";
            string s13 = s11.Insert(5, s12);
            Console.WriteLine(s13);
            s13 = s11.Remove(0, 10);// удаление 
            Console.WriteLine(s13);

            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            Console.WriteLine("\nСоздайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками");
            string text = "hello";
            string text1 = null;

            Console.WriteLine("Соединение: " + (text + text1));
            Console.WriteLine("Сравнение: " + text.CompareTo(text1));
            Console.WriteLine("Вствка: " + String.Concat(text, text1));

            //Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.
            Console.WriteLine("\nСоздайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.");
            StringBuilder fit = new StringBuilder("Факультет информационных технологий");
            Console.WriteLine(fit);
            fit.Append("\tБГТУ");
            Console.WriteLine(fit);
            Console.WriteLine(fit.Length);
            Console.WriteLine(fit.Capacity);

            fit.Insert(35, " ДЭиВИ");
            Console.WriteLine(fit);

            fit.Remove(35, 11);
            Console.WriteLine(fit);

            fit.Replace("Факультет", "Faculty");
            Console.WriteLine(fit);

            fit.AppendFormat(" BSTU ");
            Console.WriteLine(fit);
            //Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 
            Console.WriteLine("\nСоздайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). ");
            int[,] myArr = new int[3, 3];


            // Инициализируем данный массив
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = arr.GetUpperBound(0) + 1;//надо получить количество элементов в размерности.
            //получить количество строк таблицы, представленной двухмерным массивом. А через mas.Length / rows можно получить количество элементов в каждой строке:
            int columns = arr.Length / rows;


            for (int i1 = 0; i1 < rows; i1++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i1, j] + "\t");
                }
                Console.WriteLine();
            }
            // Создайте одномерный массив строк. Выведите на консоль егосодержимое, длину массива. Поменяйте произвольный элемент(пользователь определяет позицию и значение).
            Console.WriteLine("\n Создайте одномерный массив строк. Выведите на консоль егосодержимое, длину массива. Поменяйте произвольный элемент(пользователь определяет позицию и значение).");
            string[] summerMounths = { "June", "July", "August" };

            Console.WriteLine("Длинна массива: " + summerMounths.Length);
            for (i = 0; i < summerMounths.Length; i++)
            {
                Console.WriteLine(summerMounths[i]);
            }

            Console.WriteLine("Введите позицию и значение изменения\n");
            Console.Write("Позиция: ");
            int change = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nЗначение: ");
            string chname = Console.ReadLine();
            for (i = 0; i < summerMounths.Length; i++)
            {
                if (i == change)
                {
                    summerMounths[i] = chname;
                }
                Console.WriteLine(summerMounths[i]);
            }
            Console.WriteLine("\nСоздайте ступечатый(не выровненный) массив вещественных чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно.Значения массива введите с консоли.");
                           
            //            Создайте ступечатый(не выровненный) массив вещественных
            //              чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            //                  соответственно.Значения массива введите с консоли.
            Console.WriteLine("Введите элеменды ступенчатого массива ");
            int[][] Arr = new int[3][];
            Arr[0] = new int[2];
            Arr[1] = new int[3];
            Arr[2] = new int[4];

            for (i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].GetLength(0); j++)
                {
                    Arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("Arr["+i+"]["+j+"]= "+Arr[i][j]);
                }

            }


            Console.Write("\n");
            for (i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].GetLength(0); j++)
                {

                    Console.Write(+Arr[i][j]);
                }
                Console.Write("\n");
            }
            //Создайте неявно типизированные переменные для хранения массива и строки.
            var mass = new[] { 5, 10, 23, 16, 8 };
            var Str = "Hello world!";

            //Задайте кортеж из 5 элементов с типами int, string, char, string,ulong.Выведите его в консоль полностью и выборочно(1,3,4)
            Console.WriteLine("\nЗадайте кортеж из 5 элементов с типами int, string, char, string,ulong.Выведите его в консоль полностью и выборочно(1,3,4)");
            (int first, string second, char third, string fourth, ulong fifth) korteg = (10, "hello", 'S', "world", 500);
            Console.WriteLine("Кортеж целиком: "+korteg);
            Console.WriteLine("Выборочные элементы(1, 3, 4): " + korteg.first + " " + korteg.third + " "+ korteg.fourth);

            // Расспаковка кортежа
            var (name, age, country) = ("Alla", "18", "Belarus");
            var (a1, b1, c, d1, e) = korteg;

            //Cравнениие кортежей
            Console.WriteLine("\nCравнениие кортежей");
            (int first, string second, char third, string fourth, ulong fifth) korteg1 = (10, "hello", 'S', "world", 500);
            Console.WriteLine( korteg == korteg1);

            //Новая функция
            Console.WriteLine("\nСоздайте локальную функцию в main и вызовите ее. ");
            int[] mas = new int[] { 5, 20, 30, 40, 50 };
            string stringg = "Hello";
            //var tuple2 = GetValue(mas, stringg);

            Console.Write("Массив: ");

            for (i = 0; i < mas.Length; ++i) 
            {
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine("\nСтрока:"+stringg);

            static (int , int , int , char) GetValue(int[] mas, string st)
            {
                return (mas.Max(), mas.Min(), mas.Sum(), st[0]);
            }
            Console.WriteLine("Кортеж из максимального, минимального элемента, их суммы и первого символа строки \n"+GetValue(mas, stringg));
            //    var resultОfKort = (max: 0, min: 0, sum: 0, letter: "");
            //    resultОfKort.min = mas[0];
            //    resultОfKort.max = mas[0];
            //    resultОfKort.sum = 0;
              

            //    for (int i = 1; i < mas.Length; i++)
            //    {
            //        if (mas[i] > resultОfKort.max)
            //        {
            //            resultОfKort.max = mas[i];
            //        }
            //    }
            //    for (int i = 1; i < mas.Length; i++)
            //    {
            //        if (mas[i] < resultОfKort.min)
            //        {
            //            resultОfKort.min = mas[i];
            //        }
            //    }

            //    resultОfKort.letter = st.Substring(0, 1);

            //    for (int i = 0; i < mas.Length; i++)
            //    {
            //        resultОfKort.sum += mas[i];
            //    }

            //    return resultОfKort;
            //}
            //Console.WriteLine("Кортеж:"+ tuple2);
            //Console.WriteLine("Max ="+tuple2.max);
            //Console.WriteLine("Min = "+ tuple2.min);
            //Console.WriteLine("Sum = " + tuple2.sum);
            //Console.WriteLine("Letter = "+ tuple2.letter);
        }

    }

    
}

