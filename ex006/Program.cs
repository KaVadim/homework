﻿// Напишите программу, которая на вход принимает
//  число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2==1)
{
    Console.WriteLine("число нечетное"); 
}
    else 
    {
        Console.WriteLine("число четное"); 
    }
//  if (a==b)
//     {
//         Console.WriteLine("первое число равно второму");
//     }
//     else    
//             if (a>b)
//             {
//                 Console.WriteLine("первое число больше второго");
//             }
//             else
//             {
//                 Console.WriteLine("второе число больше первого");
//             }
