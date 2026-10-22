using System;
using System.Collections.Generic;

public class City
{
    private string _name;
    private List<Route> _routes;

    public City(string name)
    {
        Name = name;
        _routes = new List<Route>();
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Route> Routes
    {
        get { return _routes; }
    }

    public void AddRoute(City destination, int cost)
    {
        _routes.Add(new Route(destination, cost));
    }

    static public void Connect(City a, City b, int cost)
    {
        a.AddRoute(b, cost);
        b.AddRoute(a, cost);
    }

    public override string ToString()
    {
        string list = "";

        for (int i = 0; i < _routes.Count; i++)
        {
            if (i > 0)
            {
                list += ", ";
            }

            list += _routes[i];
        }

        return $"{_name}: [{list}]";
    }
}
