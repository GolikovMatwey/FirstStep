string? inputLKneOne = Console.ReadLine();

if(inputLKneOne != null)
{

    int inputNumber = int.Parse(inputLKneOne);

    int startNumber = (inputNumber * -1 );

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput+startNumber+", ";
        startNumber++;
    }

    lineOutput=lineOutput+inputNumber;

   Console.WriteLine(lineOutput);

}