string? inputLKneOne = Console.ReadLine();
string? inputLKneTwo = Console.ReadLine();

if (inputLKneOne != null && inputLKneTwo != null)
{
    int inputNumberOne = int.Parse(inputLKneOne);
    int inputNumberTwo = int.Parse(inputLKneTwo);

    if (inputNumberOne == inputNumberTwo * inputNumberTwo)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}