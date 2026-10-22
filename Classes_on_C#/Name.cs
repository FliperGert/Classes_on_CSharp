using System;

public class Name
{
    private string surname;
    private string firstname;
    private string middlename;

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public string Firstname
    {
        get { return firstname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Личное имя должно быть задано");
            }

            firstname = value;
        }
    }

    public string Middlename
    {
        get { return middlename; }
        set { middlename = value; }
    }

    public Name(string firstname) : this(firstname, null, null)
    {
    }

    public Name(string firstname, string surname) : this(firstname, surname, null)
    {
    }

    public Name(string firstname, string surname, string middlename)
    {
        Firstname = firstname;
        Surname = surname;
        Middlename = middlename;
    }

    public override string ToString()
    {
        string result = firstname;

        if (!string.IsNullOrWhiteSpace(surname))
        {
            result = $"{surname} {result}";
        }

        if (!string.IsNullOrWhiteSpace(middlename))
        {
            result = $"{result} {middlename}";
        }

        return result;
    }
}
