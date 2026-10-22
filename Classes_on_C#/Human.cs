using System;

public class Human
{
    private Name _name;
    private int _height;
    private Human _father;

    public Human(string name, int height) : this(new Name(name), height, null)
    {
    }

    public Human(string name, int height, Human father) : this(new Name(name), height, father)
    {
    }

    public Human(Name name, int height) : this(name, height, null)
    {
    }

    public Human(Name name, int height, Human father)
    {
        Name = name;
        Height = height;
        Father = father;
    }

    public Name Name
    {
        get { return _name; }
        set
        {
            if (value == null)
            {
                Console.WriteLine("Имя не может быть null");
                _name = new Name("Inav(null)");
            }
            else
            {
                _name = value;
                FillFromFather();
            }
        }
    }

    public int Height
    {
        get { return _height; }
        set
        {
            if (0 < value)
            {
                _height = value;
            }
            else
            {
                Console.WriteLine("Отрицательный рост быть не может");
                _height = 1;
            }
        }
    }

    public Human Father
    {
        get { return _father; }
        set
        {
            _father = value;
            FillFromFather();
        }
    }

    private void FillFromFather()
    {
        if (_father == null || _name == null)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(_name.Surname) && !string.IsNullOrWhiteSpace(_father.Name.Surname))
        {
            _name.Surname = _father.Name.Surname;
        }

        if (string.IsNullOrWhiteSpace(_name.Middlename) && !string.IsNullOrWhiteSpace(_father.Name.Firstname))
        {
            _name.Middlename = MakeMiddlename(_father.Name.Firstname);
        }
    }

    private static string MakeMiddlename(string fatherName)
    {
        if (fatherName == "Лев")
        {
            return "Львович";
        }

        if (fatherName == "Пётр")
        {
            return "Петрович";
        }

        char last = fatherName[fatherName.Length - 1];
        string stem = fatherName.Substring(0, fatherName.Length - 1);

        if (last == 'й' || last == 'ь')
        {
            return stem + "евич";
        }

        if (last == 'я')
        {
            return stem + "ьич";
        }

        if (last == 'а')
        {
            return stem + "ич";
        }

        return fatherName + "ович";
    }

    public override string ToString()
    {
        FillFromFather();

        return $"{_name}, рост: {_height}";
    }
}
