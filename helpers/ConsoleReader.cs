using System;
class ConsoleReader
{
    public ConsoleReader()
    {
        Console.WriteLine("[ConsoleReader] Created instance of ConsoleReader");
    }

    public int ReadNumber()
    {
        var input = Console.ReadLine();
        int number;
        while (!Int32.TryParse(input, out number))
        {
            Console.WriteLine($"{input} is not a number");
            input = Console.ReadLine();
        }
        return number;
    }

    public string ReadString()
    {
        return Console.ReadLine();
    }
}
