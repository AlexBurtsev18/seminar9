// Begin
// Task 1. Задайте значеие N и покажите все значения от 1 до N.

// void ShowNums(int num)
// {
//     if(num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }
// ShowNums(5);

// Task 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if(num != 0) return SumOfDigits(num / 10) + num % 10;
//     return 0;
// }

// Console.WriteLine(SumOfDigits(123));

// Task 3. Задайте значение m и n. и напишите программу, которая выдаст числа от m до n. 
// void 

// void PrintNums(int m, int n)
// {
//     if(n>m)
//     {
//         PrintNums(m, n-1); 
//         Console.Write(n + " ");
//     }
//     else if(m>n)
//     {
//         Console.Write(m + " ");
//         PrintNums(n, m-1);
//     }
//     if(n==m) Console.Write(m + " ");
// }

// PrintNums(5, 2);

// Task 4. Напишите програму, которая принимает на вход два числа a и b, и возводит число a в степень b.

// int Stepen(int a, int b)
// { 
//     if(b != 0) return Stepen(a, b-1) * a;
//     return 1;
// }
// Console.Write(Stepen(2, 3));

// HOWEWORK. 

// Task 64++. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void RecFromOne(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) RecFromOne(n - 1);
// }

// RecFromOne(5);

// Task 66++: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumBetweenNumbers(int m, int n)
// {
//     if(n >= m) return n + SumBetweenNumbers(m, n-1);
//     return 0;
// }
// Console.Write(SumBetweenNumbers(4,8));

// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if(m == 0) return n+1;
//     else if(n == 0) return Akkerman(m-1, 1);
//     else return Akkerman(m-1, Akkerman(m, n-1));
// }

// Console.Write(Akkerman(3,2));