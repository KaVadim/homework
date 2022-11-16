// напишите прогу, кот на вход принимает 2 числа и проверяет, 
// явл ли первое число квадратом второго
Console.WriteLine("Введите число 'a' ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b' ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==b*b)
{
    Console.WriteLine("первое число это квадрат второго");
}
else
{
    Console.WriteLine("НЕА");
}