Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное число {number}");
int n1 = number % 100;
if (n1 > 0)
    Console.WriteLine(n1);
else 
    Console.WriteLine("no");
