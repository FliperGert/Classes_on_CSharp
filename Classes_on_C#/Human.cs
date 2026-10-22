using System;

public class Human
{
    private Name name;
    private int height;
    private Human father;

    public Name Name
    {
        get { return name; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "Имя не может быть null");
            }

            name = value;
            FillFromFather();
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (0 < value)
            {
                height = value;
            }
            else
            {
                Console.WriteLine("Отрицательный рост быть не может");
                height = 1;
            }
        }
    }

    public Human Father
    {
        get { return father; }
        set
        {
            father = value;
            FillFromFather();
        }
    }

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

    private void FillFromFather()
    {
        if (father == null || name == null)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(name.Surname) && !string.IsNullOrWhiteSpace(father.Name.Surname))
        {
            name.Surname = father.Name.Surname;
        }

        if (string.IsNullOrWhiteSpace(name.Middlename) && !string.IsNullOrWhiteSpace(father.Name.Firstname))
        {
            name.Middlename = MakeMiddlename(father.Name.Firstname);
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

        return $"{name}, рост: {height}";
    }
}
