
Console.WriteLine("введи число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введи второе число");
int b = Convert.ToInt32(Console.ReadLine());

 double x = a, y = b;

    double result = Math.Pow(x, y);

    Console.WriteLine($"{x} ^ {y} = {result}");