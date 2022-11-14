using System;

namespace BaseFunctions
{
    
    class Program
    {
        // Функция сортировки, которая использует циклы и ветвления
        static void Sort<T>(ref T[] nums) where T: IComparable<T>
        {
            T temp;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i].CompareTo(nums[j]) < 0)
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }                 
                }
            }
        }

        // Функция вывода на консоль
        static void PrintSorted<T>(T[] nums)
        {
            Console.WriteLine("Отсортированный массив:\n");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}\t");
            }
        }

        static void Main(string[] args)
        {            
            try
            {
                // Способ работы с консолью
                if (args.Length == 0)
                {
                    Console.WriteLine("Выберите тип массива:\n1 - целочисленный массив\n2 - массив строк");
                    int typeOfWork = Convert.ToInt32(Console.ReadLine());

                    if(typeOfWork == 1)
                    {
                        Console.WriteLine("Введите размер массива целых чисел:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] nums = new int[size];
                        Console.WriteLine("Введите числа");
                        for(int i = 0;i < size; i++)
                        {
                            nums[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Sort(ref nums);
                        PrintSorted(nums);
                    }

                    else if(typeOfWork == 2)
                    {
                        Console.WriteLine("Введите размер массива строк:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        string[] nums = new string[size];
                        Console.WriteLine("Введите строки");
                        for (int i = 0; i < size; i++)
                        {
                            nums[i] = Console.ReadLine();
                        }
                        Sort(ref nums);
                        PrintSorted(nums);
                    }
                }
                // Способ работы с командной строкой (Работа с ОС)
                else
                {
                    Sort(ref args);
                    PrintSorted(args);
                }

            }
            catch {
                Console.WriteLine("Ошибка!");
            }   
        }
    }
}
