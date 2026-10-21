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
        set { firstname = value; }

    }

    public string Middlename
    {
        get { return middlename; }
        set { middlename = value; }

    }

    public Name(string firstname)
    {
        Firstname = firstname;
        this.surname = null;
        this.middlename = null;
    }

    public Name(string firstname, string surname)
    {
        Firstname = firstname;
        Surname = surname;
        this.middlename = null;
    }

    public Name(string firstname, string surname, string middlename)
    {
        Firstname = firstname;
        Surname = surname;
        Middlename = middlename;
    }


    public override string ToString()
    {
        if (!string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(middlename))
        {
            return $"{firstname}";
        }
        else if (!string.IsNullOrWhiteSpace(middlename))
        {
            return $"{surname} {firstname}";
        }
        else
        {
            return $"{surname} {firstname} {middlename}";
        }
    }
}
