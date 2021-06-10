using System;

namespace Basic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 0; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            var total = 0;
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
                total += i;
                Console.WriteLine(total);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            var total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            var average = total/numbers.Length;

            Console.WriteLine(average);
        }

        public static int[] OddArray()
        {
            int[] newArr = new int[256/2];
            int idx = 0;
            for(int i = 1; i < 256; i += 2)
            {
                newArr[idx] = i;
                idx++;
            }
            return newArr;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            var total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    total++;
                }
            }
            return total;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        public static void MinMaxAverage(int[] numbers)
        {
            var max = numbers[0];
            var min = numbers[0];
            var sum = 0;
            var average = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            average = sum/numbers.Length;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(average);
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length -1] = 0;
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    newArr[i] = "Dojo";
                }
                else
                {
                    newArr[i] = numbers[i];
                }
            }

            return newArr;
        }



        static void Main(string[] args)
        {
           Console.WriteLine("[{0}]", string.Join(", ", NumToString(new int[] {-1, -3, 2})));
        }
    }
}
