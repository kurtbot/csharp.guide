abstract class Example
{
    private string _name = "";

    public string Name
    {
        get
        {
            return _name;
        }
    }

    Example(string exampleName)
    {
        _name = exampleName;
    }

    public abstract void run()
    {
        Console.WriteLine("Example.run()");
    }
}
