Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (b < a && a > c)
{
    Console.WriteLine("Первое число самое боьшое");
}
else if (a < b && b > c)
{
    Console.WriteLine("Второе число самое боьшое");
}
else if (b < c && c > a)
{
    Console.WriteLine("Третье число самое большое");
}