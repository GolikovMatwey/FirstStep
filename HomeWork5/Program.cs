Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
string? A = Console.ReadLine();
Char[] B = A.ToCharArray();
if(B.Length > 2)
{
Console.WriteLine(B[2]);
}
else
{
 Console.WriteLine("НЕДОПУСТИМОЕ ЧИСЛО");
}