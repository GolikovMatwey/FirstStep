double A = double.Parse(Console.ReadLine());
int B = 2; 
string Line = ""; 
while ( B < A )
{
   Line  =  Line  + B + ", ";
   B = B + 2;
}
Console.WriteLine(Line);