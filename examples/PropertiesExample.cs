using System;
class PropertiesExample : Example
{
    ConsoleReader cr;

    // #region PROPERTIES
    private int _numberProperty;

    public int NumberProperty
    {
        get
        {
            return _numberProperty;
        }
        set
        {
            // to access the value to be set, use the `value` keyword
            _numberProperty = value;
        }
    }

    private int _conditionedNumberProperty;

    public int ConditionedNumberProperty
    {
        get
        {
            return _conditionedNumberProperty;
        }
        set
        {
            if (value > _conditionedNumberProperty)
                _conditionedNumberProperty = value;
        }
    }

    private int _getOnlyNumberProperty = 100;

    public int ReadOnlyNumberProperty
    {
        get
        {
            return _getOnlyNumberProperty;
        }
    }

    // #endregion
    public PropertiesExample() : base("PropertiesExample")
    {
        cr = new ConsoleReader();
    }

    public override void run()
    {
        Console.WriteLine("PropertiesExample was ran");
    }
}
