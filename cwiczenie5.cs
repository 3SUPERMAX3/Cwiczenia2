Console.WriteLine("Wprowadź dwie liczby a i b: ");

Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());


if (a == b)
{
    Console.WriteLine("Liczby są takie równe");
}
else
{
    Console.WriteLine($"Większa liczba to {Math.Max(a, b)}");
}