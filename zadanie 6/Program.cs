Console.WriteLine("Wprowadź długości boków trójkąta - a, b i c");

Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Z tych boków powstanie trójkąt równoboczny");
}
else
    Console.WriteLine("Z tych boków nie powstanie trójkąt równoboczny ani równoramienny");