// программа с целыми числами от "-Н" до "Н"
Console.WriteLine("ВВедите число");
int a = Convert.ToInt32(Console.ReadLine());

for (int i=-a;i<a+1;i++)
{
    Console.Write(i);
}