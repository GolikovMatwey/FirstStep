 Console.WriteLine ("Введите 3 числа");
 string? A = Console.ReadLine();
 string? B = Console.ReadLine();
 string? C = Console.ReadLine();

int iuntA = int.Parse(A);
int iuntB = int.Parse(B);
int iuntC = int.Parse(C);

if (iuntA > iuntB)
{ 
    if (iuntA > iuntC)
    {
    Console.WriteLine(iuntA);
    }
    else
    {
    Console.WriteLine(iuntC);
    }
} 
else
{ if (iuntB > iuntC)
{
    Console.WriteLine(iuntB);
}
else
{
    Console.WriteLine(iuntC);
}   
}