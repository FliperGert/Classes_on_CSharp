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
        int x;

        if (Int32.TryParse(data, out x))
        {
            return true;
        }

        return false;
    }

    static public int InputInt(string info)
    {
        string data;

        do
        {
            Console.WriteLine(info);
            data = Console.ReadLine();

            if (!IsInt(data))
            {
                Console.WriteLine("Вы ввели не целое число, повторите попытку");
            }
        }
        while (!IsInt(data));

        return Int32.Parse(data);
    }

    static public int InputInt(string info, int min, int max)
    {
        int x;

        do
        {
            x = InputInt(info);

            if (x < min || x > max)
            {
                Console.WriteLine($"Число должно быть от {min} до {max}, повторите попытку");
            }
        }
        while (x < min || x > max);

        return x;
    }

    static public string InputString(string info)
    {
        string data;

        do
        {
            Console.WriteLine(info);
            data = Console.ReadLine().Trim();

            if (data.Length == 0)
            {
                Console.WriteLine("Строка не может быть пустой, повторите попытку");
            }
            else if (!IsStringWithoutDigits(data))
            {
                Console.WriteLine("Строка не должна содержать цифры, повторите попытку");
            }
        }
        while (data.Length == 0 || !IsStringWithoutDigits(data));

        return data;
    }

    static public string InputOptionalString(string info)
    {
        string data;

        do
        {
            Console.WriteLine(info);
            data = Console.ReadLine().Trim();

            if (data.Length > 0 && !IsStringWithoutDigits(data))
            {
                Console.WriteLine("Строка не должна содержать цифры, повторите попытку");
            }
        }
        while (data.Length > 0 && !IsStringWithoutDigits(data));

        if (data.Length == 0)
        {
            return null;
        }

        return data;
    }
}
