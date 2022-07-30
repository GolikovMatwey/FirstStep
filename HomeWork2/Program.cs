Console.WriteLine("Введите цифру");

string? A = Console.ReadLine();

int iuntA = int.Parse(A);

 int B = iuntA / 2;

if (B == 0)
{
    Console.WriteLine("ЧЁТНОЕ");
}
else
{
    Console.WriteLine("НЕ ЧЁТНОЕ");
}