using System;

public class HumanWithName : Human
{
    private Name name;
    private HumanWithName father;

    public new Name Name
    {
        get { return name; }
        set { name = value; }
    }
    public HumanWithName Father
    {
        get { return father; }
        set { father = value; }
    }
    public HumanWithName(string firstname, int height, HumanWithName father = null)
    { 
        Name = new Name(firstname);
        Height = height;
        Father = father;
    }

    public HumanWithName(string firstname, string surname, int height, HumanWithName father = null)
    {
        Name = new Name(firstname, surname);
        Height = height;
        Father = father;

    }

    public HumanWithName(string firstname, string surname, string middlename, int height, HumanWithName father = null)
    {
        Name = new Name(firstname, surname, middlename);
        Height = height;
        Father = father;
    }


    public override string ToString()
    {
        
        if (Name.Surname is null && !(Father?.Name.Surname is null))
        {
            Name.Surname = Father.Name.Surname;
        }

        if (Name.Middlename is null && !(Father?.Name.Firstname is null))
        {
            Name.Middlename = Father.Name.Firstname + "ович";
        }

        return $"Человек с именем {Name} и ростом {Height}";
    }
}
