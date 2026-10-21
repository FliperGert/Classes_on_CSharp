using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Human
{
    private string firstname;
    private int height;

    public string Name
    {
        get { return firstname; }
        set { firstname = value; }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (0 < height)
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

}

