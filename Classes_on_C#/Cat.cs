using System;

public class Cat
{
    private string _name;

    public Cat(string name)
    {
        Name = name;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("У кота должно быть имя");
                _name = "Барсик(null)";
            }
            else
            {
                _name = value;
            }
        }
    }

    public void Meow()
    {
        Console.WriteLine($"{_name}: мяу!");
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

        Console.WriteLine($"{_name}: {result}!");
    }

    public override string ToString()
    {
        return $"кот: {_name}";
    }
}
