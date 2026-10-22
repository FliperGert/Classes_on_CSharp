using System;

public class Name
{
    private string _surname;
    private string _firstname;
    private string _middlename;

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

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public string Firstname
    {
        get { return _firstname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Личное имя должно быть задано");
            }
            else
            {
                _firstname = value;
            }
        }
    }

    public string Middlename
    {
        get { return _middlename; }
        set { _middlename = value; }
    }

    public override string ToString()
    {
        string result = _firstname;

        if (!string.IsNullOrWhiteSpace(_surname))
        {
            result = $"{_surname} {result}";
        }

        if (!string.IsNullOrWhiteSpace(_middlename))
        {
            result = $"{result} {_middlename}";
        }

        return result;
    }
}
