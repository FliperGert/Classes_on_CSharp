using System;

public class Cat
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("У кота должно быть имя");
            }

            name = value;
        }
    }

    public Cat(string name)
    {
        Name = name;
    }

    public void Meow()
    {
        Console.WriteLine($"{name}: мяу!");
    }

    public void Meow(int n)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            if (i > 0)
            {
                result += "-";
            }

            result += "мяу";
        }

        Console.WriteLine($"{name}: {result}!");
    }

    public override string ToString()
    {
        return $"кот: {name}";
    }
}
