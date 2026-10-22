using System;

public class City
{
    private string name;
    private object[] pairs;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public object Pairs{
        get { return Pairs; }
        set
        { 
            if (typeof(value) == object)
            {
                Pairs = value;
            }
            else
            {
                Console.WriteLine("Не подходящий тип данных");
            }
        }
    }
}
