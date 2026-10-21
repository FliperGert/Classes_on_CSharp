using System;

public class Check
{
    static public bool IsStringWithoutDigits(string data)
    {
        foreach (char c in data)
        {
            if (Char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }


    static public bool IsInt(string data)
    {
        if(Int32.TryParse(data, out int x))
        {
            return true;
        }
        return false;
    }

    static public int InputInt(string info)
    {
        string data;
        int x;
        do
        {
            Console.WriteLine(info);
            data = Console.ReadLine();

        } while (Int32.TryParse(data, out x));
        return x;
    }
}
