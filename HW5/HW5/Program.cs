using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            string input1 = Console.ReadLine();
            if (int.TryParse(input1, out var n))
            {
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Введите {i + 1} элемент  массива");
                    string input2 = Console.ReadLine();
                    if (int.TryParse(input2, out var intNum))
                    {
                        arr[i] = intNum;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста введите корректное значение элемента массива");
                        i--;
                    }

                }

                foreach(var el in arr)
                {
                    Console.Write(el);
                }
                /*Task1
                Найти минимальный элемент массива(первый встретившийся)*/
                // MinValue(arr);


                /* Task2
                Найти максимальный элемент массива*/
                //MaxValue(arr);


                /*Task3
                Найти индекс минимального элемента массива*/
                //MinElIndex(arr);


                /*Task4
                Найти индекс максимального элемента массива*/
                //MaxElIndex(arr);


                /*Task5
                Посчитать сумму элементов массива с нечетными индексами*/
                //SumOddIndex(arr);


                /*Task6
                Сделать реверс массива(массив в обратном направлении)*/
                //Reverse(arr);


                /*Task7
                Посчитать количество нечетных элементов массива*/
                //CalcOddEl(arr);


                /*Task8
                Поменять местами первую и вторую половину массива,
                например, для массива 1 2 3 4, результат 3 4 1 2, или
                для 12345 - 45312.*/
                //ChangeHalfMass(arr);


                /*Task9
                Отсортировать массив по возрастанию одним из способов: 
                пузырьком(Bubble), выбором(Select) или вставками(Insert))*/
                //BubleSearch(arr);


                /*Task10
                 Отсортировать массив по убыванию одним из
                 способов, (отличным от способа в 9 - м задании) : 
                 пузырьком(Bubble), выбором(Select) или вставками(Insert)) */
                 //InsertSort(arr);

            }
            else
            {
                Console.WriteLine("Пожалуйста введите корректный размер массива");
            }
        }



        /* Task1*/
        private static void MinValue(int[] arr)
        {

            int minEl = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minEl)
                {
                    minEl = arr[i];
                }
            }
            Console.WriteLine($"Минимальный элемент массива равен {minEl}");

        }



        /*Task2*/
        private static void MaxValue(int[] arr)
        {
            int maxEl = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxEl)
                {
                    maxEl = arr[i];
                }
            }

            Console.WriteLine($"Максимальный элкмент массива {maxEl}");
        }



        /*Task3*/
        private static void MinElIndex(int []arr)
        {
            int minEl = arr[0];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minEl)
                {
                    minEl =arr[i];
                    index = i;
                }
            }
            Console.WriteLine($"Индекс минимального элемента массива равен {index}");
        }



        /*Task4*/
        private static void MaxElIndex(int [] arr)
        {
            int maxEl = arr[0];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxEl)
                {
                    maxEl = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"Индекс максимального элемента массива равен {index}");
        }



        /*Task5*/
        private static void SumOddIndex(int []arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Сумма элементов массива с нечетными индексами равна {sum}");
        }



        /*Task6*/
        private static void Reverse(int []arr)
        {
            Console.Write("Реверс массива ");
            foreach(var el in arr)
            {
                Console.Write(el+" ");
            }
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = t;
            }
            Console.Write("равен ");
            foreach (var el in arr)
            {
                Console.Write(el+" ");
            }
        }



        /*Task7*/
        private static void CalcOddEl(int []arr)
        {
            int culc = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 != 0)
                {
                    culc += 1;
                }
            }
            Console.WriteLine($"Колличество нечетных элементов в массиве {culc}");
        }



        /*Task8*/
        private static void ChangeHalfMass(int[] arr)
        {
            int temp = arr[0];
            Console.Write("Массив ");
            foreach(var el in arr)
            {
                Console.Write(el+" ");
            }

            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length / 2 + i];
                    arr[arr.Length / 2 + i] = temp;
                }
            }
            else
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[(arr.Length + 1) / 2 + i];
                    arr[(arr.Length + 1) / 2 + i] = temp;
                }
            }
            Console.Write(" результат ");
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
        }



        /*Task9*/
        private static void BubleSearch(int []arr)
        {
            int temp = arr[0];
            Console.Write("Массив ");
            foreach(var el in arr)
            {
                Console.Write(el+" ");
            }
            Console.Write("отсортированный по возрастанию ");
            for(int i = 0; i < arr.Length; i++)
            {
             for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(var el in arr)
            {
                Console.Write(el+" ");
            }
        }



        /*Task10*/
        private static void InsertSort(int []arr)
        {
            Console.Write("Массив ");
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.Write("отсортированный по возрастанию ");
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    var temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                }
            }
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
        }

       

    }
}
