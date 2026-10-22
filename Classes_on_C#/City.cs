using System;
using System.Collections.Generic;

public class City
{
    private string name;
    private List<Route> routes;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Route> Routes
    {
        get { return routes; }
    }

    public City(string name)
    {
        Name = name;
        routes = new List<Route>();
    }

    public void AddRoute(City destination, int cost)
    {
        routes.Add(new Route(destination, cost));
    }

    static public void Connect(City a, City b, int cost)
    {
        a.AddRoute(b, cost);
        b.AddRoute(a, cost);
    }

    public override string ToString()
    {
        string list = "";

        for (int i = 0; i < routes.Count; i++)
        {
            if (i > 0)
            {
                list += ", ";
            }

            list += routes[i];
        }

        return $"{name}: [{list}]";
    }
}
