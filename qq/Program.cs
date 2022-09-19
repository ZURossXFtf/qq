// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    double res = Math.Sin(Math.Sqrt(x + 1)) - Math.Sin(Math.Sqrt(x - 1));
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
