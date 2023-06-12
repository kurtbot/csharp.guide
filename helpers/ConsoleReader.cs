using System.Console;

class ConsoleReader
{
    ConsoleReader()
    {
        Console.WriteLine("[ConsoleReader] Created instance of ConsoleReader");
    }

    public int ReadNumber()
    {
        var input = Console.ReadLine();
        int number;
        while (!Int32.TryParse(input, out number))
        {
            Console.Writeline($"{input} is not a number");
            input = Console.ReadLine();
        }
        return number;
    }
}
