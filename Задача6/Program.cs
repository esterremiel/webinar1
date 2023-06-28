Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a%2;

if(b == 1 || b == -1)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}