Console.Clear();
Console.WriteLine("Введите Число ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
if (n < 100)
    Console.WriteLine("третьей цифры нет");
else 
{
    while(m > 999) m /= 10;
    Console.WriteLine(m % 10);
}
