double I = 0;
Console.WriteLine("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите n:");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B:");
double B = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите шаг:");
double N = Convert.ToDouble(Console.ReadLine());
do
{
    I += (0.5 * Math.Pow(x, a)) + ((Math.Cos(Math.Pow(x, n) + n)) / (Math.Pow(x, 2) - (b * Math.Sqrt(b)))) + (Math.Tan(Math.Pow(n, 3)));
    b += N;
} while (b < B);
Console.WriteLine("Ответ: ");
Console.WriteLine(Convert.ToString(Math.Round(I, 2)));