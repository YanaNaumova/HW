using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr;
            myArr = CreateArrayFillRandom();
            PrintArray(myArr);


            /*Task1
             Найти минимальный элемент массива*/
            MinEl(myArr);


            /*Task2
             Найти максимальный элемент массива*/
            MaxEl(myArr);


            /*Task3
            Найти индекс минимального элемента массива*/
            MinElInd(myArr);


            /*Task4
            Найти индекс максимального элемента массива*/
            MaxElInd(myArr);


            /* Task5
             Найти количество элементов массива, которые больше всех своих соседей*/
            MaxNeighb(myArr);


            /*Task6
            Вводим число(0 - 999), получаем строку с прописью числа.*/
            /*do
            {
                Console.WriteLine("Введите число от 0 до 999");
                string input = Console.ReadLine();
                if (int.TryParse(input, out var n))
                {
                    SpellNum(n);
                }
                else
                {
                    Console.WriteLine("Пожалуйста введите корректное значение");
                }
            } while (true);*/



            /*Task7
            Вводим строку, которая содержит число, написанное прописью(0 - 999).Получить само число*/
            /* while (true)
             {

                 string[,] str = new string[4, 9]{{"один","два","три","четыре","пять","шесть","семь","восемь","девять"},
                                          {"одинадцать","двенадцать","тренадцать","четырнадцать","пятнадцать","шестнадцать","семнадцать","восемнадцать","девятнадцать"},
                                          {"десять","двадцать","тридцать","сорок","пятьдесят","шестьдесят","семьдесят","восемьдесят","девяносто"},
                                          {"сто","двести","триста","четыреста","пятсот","шестсот","семсот","восемсот","девятсот" } };

                 Console.WriteLine("Введите число на русском от 0 до 999");
                 string input = Console.ReadLine().ToLower().Trim();
                 string[] words = input.Split(new char[] { ' ' });
                 int un = 0;
                 int dec = 0;
                 int con = 0;
                 int result = 0;
                 int row = str.GetLength(0);
                 int column = str.GetLength(1);
                 int count = 0;
                 int variable = 0;
                 if (input == "ноль")
                 {
                     result = 0;
                     variable = 1;
                 }
                 else
                 {
                     for (int k = 0; k < words.Length; k++)
                     {
                         for (int i = 0; i < row; i++)
                         {
                             for (int j = 0; j < column; j++)
                             {
                                 if ((words.Length == 3 && str[i, j] == words[k]) || (words.Length == 2 && str[i, j] == words[k]) || (words.Length == 1 && str[i, j] == words[k]))
                                 {
                                     count += 1;
                                 }

                                 if ((words.Length == 3 && count == 3) || (words.Length == 2 && count == 2) || (words.Length == 1 && count == 1))
                                 {
                                     variable = 1;
                                 }
                             }
                         }
                     }
                 }


                 if (variable == 1)
                 {
                     for (int k = 0; k < words.Length; k++)
                     {
                         for (int i = 0; i < row; i++)
                         {
                             for (int j = 0; j < column; j++)
                             {
                                 if (str[i, j] == words[k])
                                 {
                                     if (i == 1)
                                     {
                                         dec = j + 11;
                                     }
                                     else if (i == 2)
                                     {
                                         dec = (j + 1) * 10;
                                     }
                                     else if (i == 3)
                                     {
                                         con = (j + 1) * 100;
                                     }
                                     else
                                     {
                                         un = j + 1;
                                     }
                                 }

                             }
                         }
                     }
                 }
                 else
                 {
                     Console.WriteLine("Пожалуйста введите коррекктное число");
                     continue;
                 }

                 result = con + dec + un;
                 Console.WriteLine(result);
             }

 */
        }

        private static int[,] CreateArrayFillRandom()
        {

            int[,] myArr = new int[3, 5];

            Random rnd = new Random();
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    myArr[i, j] = rnd.Next(100);
                }
            }
            return myArr;
        }

        private static void PrintArray(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(myArr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        /*Task1*/
        private static void MinEl(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            int minEl = myArr[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (myArr[i, j] < minEl)
                    {
                        minEl = myArr[i, j];
                    }
                }
            }
            Console.WriteLine($"Минимальный элемент равен {minEl}");
        }


        /*Task2*/
        private static void MaxEl(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            int maxEl = myArr[0, 0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (myArr[i, j] > maxEl)
                    {
                        maxEl = myArr[i, j];
                    }
                }
            }
            Console.WriteLine($"Максимальный элемент равен {maxEl}");
        }


        /*Task3*/
        private static void MinElInd(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            int minEl = myArr[0, 0];
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (myArr[i, j] < minEl)
                    {
                        minEl = myArr[i, j];
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine($"Индекс минимального элемента массива [{indexI},{indexJ}]");
        }


        /*Task4*/
        private static void MaxElInd(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            int maxEl2 = myArr[0, 0];
            int indexI1 = 0;
            int indexJ1 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (myArr[i, j] > maxEl2)
                    {
                        maxEl2 = myArr[i, j];
                        indexI1 = i;
                        indexJ1 = j;
                    }
                }
            }

            Console.WriteLine($"Индекс максимально элемента массива [{indexI1},{indexJ1}]");
        }


        /*Task5*/
        private static void MaxNeighb(int[,] myArr)
        {
            int row = myArr.GetLength(0);
            int column = myArr.GetLength(1);
            int count = 0;
            if (myArr[0, 0] > myArr[0, 1] && myArr[0, 0] > myArr[1, 0])
            {
                count += 1;
            }
            if (myArr[0, column - 1] > myArr[0, column - 2] && myArr[0, column - 1] > myArr[1, column - 1])
            {
                count += 1;
            }
            if (myArr[row - 1, 0] > myArr[row - 1, 1] && myArr[row - 1, 0] > myArr[row - 2, 0])
            {
                count += 1;
            }
            if (myArr[row - 1, column - 1] > myArr[row - 2, column - 1] && myArr[row - 1, column - 1] > myArr[row - 1, column - 2])
            {
                count += 1;
            }
            for (int i = 1; i < row - 1; i++)
            {
                for (int j = 1; j < column - 1; j++)
                {
                    if (myArr[i, j] > myArr[i - 1, j] && myArr[i, j] > myArr[i + 1, j] && myArr[i, j] > myArr[i, j - 1] && myArr[i, j] > myArr[i, j + 1])
                    {
                        count += 1;
                    }
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j < column - 1; j++)
                {
                    if (myArr[i, j] > myArr[i, j + 1] && myArr[i, j] > myArr[0, j - 1] && myArr[i, j] > myArr[i + 1, j])
                    {

                        count += 1;
                    }
                }
            }

            for (int i = row - 1; i < row; i++)
            {
                for (int j = 1; j < column - 1; j++)
                {
                    if (myArr[i, j] > myArr[i, j + 1] && myArr[i, j] > myArr[0, j - 1] && myArr[i, j] > myArr[i - 1, j])
                    {

                        count += 1;
                    }
                }
            }

            for (int i = 1; i < row - 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (myArr[i, j] > myArr[i - 1, j] && myArr[i, j] > myArr[i + 1, j] && myArr[i, j] > myArr[i, j + 1])
                    {
                        count += 1;
                    }
                }
            }


            for (int i = 1; i < row - 1; i++)
            {
                for (int j = column - 1; j < column; j++)
                {
                    if (myArr[i, j] > myArr[i - 1, j] && myArr[i, j] > myArr[i + 1, j] && myArr[i, j] > myArr[i, j - 1])
                    {
                        count += 1;
                    }
                }
            }

            Console.WriteLine($"количество элементов массива, которые "+ 
              $"больше всех своих соседей одновременно равно {count}");
        }


        /*Task6*/
        private static void SpellNum(int n)
        {
                string[,] a = new string[4, 9] {{"один","два","три","четыре","пять","шесть","семь","восемь","девять"},
                              {"десять","двадцать","тридцать","сорок","пятьдесят","шестьдесят","семьдесят","восемьдесят","девяносто"},
                              {"сто","двести","триста","четыреста","пятьсот","шестьсот","семьсот","восемьсот","девятьсот" },
                              {"одиннадцать","двенадцать","тринадцать","четырнадцать","пятнадцать","шестнадцать","семнадцать","восемнадцать","девятнадцать"}};

 
                    string s = "";
                    if (n == 0)
                    {
                        s = "ноль";
                    }
                    else if (n < 0 || n > 999)
                    {
                        Console.WriteLine("Пожалуйста введите корректное значение");
                    }
                    else if (n > 10 && n < 20)
                    {
                        s = a[3, n % 10 - 1];
                    }
                    else if ((n > 110 && n < 120) || (n > 210 && n < 220) || (n > 310 && n < 320) || (n > 410 && n < 420) || (n > 510 && n < 520) ||
                     (n > 610 && n < 620) || (n > 710 && n < 720) || (n > 810 && n < 820) || (n > 910 && n < 920))
                    {
                        s = a[2, n / 100 - 1] + ' ' + a[3, n % 10 - 1];
                    }
                    else
                    {

                        for (int i = 0, k = 0; n > 0; n /= 10, i++)
                        {
                            k = n % 10;
                            if (k != 0)
                            {
                                s = a[i, k - 1] + ' ' + s;
                            }
                        }
                    }
                    Console.WriteLine(s);
          

        }


    }
}



