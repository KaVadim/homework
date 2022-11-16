// Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());


     {     
        int maximal = Math.Max(Math.Max(a, b), c);
        int minimal = Math.Min(Math.Min(a, b), c);
 
        Console.WriteLine(" максимальное число - {2}",
            minimal,
            a + b + c - maximal - minimal,
            maximal);
    }