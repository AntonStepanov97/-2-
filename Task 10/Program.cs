Console.Clear();
int number = new Random().Next(10,100);
Console.WriteLine($"Сгенирированное число: {number}");
int n1 = number / 10;
int n2 = number % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);