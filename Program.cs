using System;

namespace Console_Program
{
    class C_1
    {
        public static int Max(int max, int b) {
            return (max < b) ? b : max;
        }

        public static string Even_number(int a) {
            return (a % 2 == 0) ? "да" : "нет";
        }

        private static void Main(string[] args)
        {
            int a, b, c;
            // 	Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine($"Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

            // 	a = 5; b = 7 -> max = 7
            a = 5; b = 7;
            Console.WriteLine($"a = {a}; b = {b} -> max = {Max(a, b)}");

            // a = 2 b = 10 -> max = 10
            a = 2; b = 10;
            Console.WriteLine($"a = {a}; b = {b} -> max = {Max(a, b)}");

            // a = -9 b = -3 -> max = -3
            a = -9; b = -3;
            Console.WriteLine($"a = {a}; b = {b} -> max = {Max(a, b)}");
            

            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
             Console.WriteLine($"\nЗадача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            // 2, 3, 7 -> 7
            a = 5; b = 7; c = 7;
            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {Max(Max(a, b), c)}");

            // 44 5 78 -> 78
            a = 44; b = 5; c = 78;
            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {Max(Max(a, b), c)}");

            // 22 3 9 -> 22
            a = 22; b = 3; c = 9;
            Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {Max(Max(a, b), c)}");


            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            Console.WriteLine($"\nЗадача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
            // 4 -> да
            a = 4;
            Console.WriteLine($"число {a} четное число > {Even_number(a)}");

            // -3 -> нет
            a = -3;
            Console.WriteLine($"число {a} четное число > {Even_number(a)}");

            // 7 -> нет
            a = 7;
            Console.WriteLine($"число {a} четное число > {Even_number(a)}");


            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            Console.WriteLine($"\nЗадача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
            // 5 -> 2, 4
            a = 5;
            Console.Write($"При N == {a}. Четные число от 1 до {a} включительно: ");
            var someList = new List<int>(); 
            for (int i = 1; i <= a; i++) {
                if (i % 2 == 0) {
                    someList.Add(i);
                }
            }
            Console.WriteLine($"{string.Join(", ", someList)}"); 
            
            someList.Clear();
            // 8 -> 2, 4, 6, 8
            a = 8;
            Console.Write($"При N == {a}. Четные число от 1 до {a} включительно: ");
            for (int i = 1; i <= a; i++) {
                if (i % 2 == 0) {
                    someList.Add(i);
                }
            }
            Console.WriteLine($"{string.Join(", ", someList)}");        
        }
    }
}