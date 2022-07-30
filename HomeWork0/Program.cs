Console.WriteLine("Введите 2 цифры:");

string A = Console.ReadLine() ?? "";
string B = Console.ReadLine() ?? "";

int iuntA = int.Parse(A);
int iuntB = int.Parse(B);

if (iuntA > iuntB)
{
    Console.WriteLine(A);
}
else;
{
    Console.WriteLine(B);
}
