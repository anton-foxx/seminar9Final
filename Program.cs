// Задача 64: Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// n1: Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > n) 
// {
//     Console.WriteLine("Введено некорректное значение N, введите значение > M");
//     goto n1;
// }

// void OutputNum(int m, int n)

// {
//     if (m <= n)
//     {
//         if (m % 3 == 0)
//         {
//             Console.Write($"{m}"+" ");
//             m++;
//             OutputNum(m, n);
//         }
//         else
//         {
//             m++;
//             OutputNum(m, n);
//         }
//     }
// }
// OutputNum(m, n);


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = InputNumbers("Введите значение m: ");
// int n = InputNumbers("Введите значение n: ");
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSumm(m, n, temp=0);

// void PrintSumm(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n}= {summ} ");
//     return;
//   }
//   PrintSumm(m, n - 1, summ);
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = InputNumbers("Введите число m: ");
// int n = InputNumbers("Введите число n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана: m = {m}, n = {n} - > A(m,n) =  {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }