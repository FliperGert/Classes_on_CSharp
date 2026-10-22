using System;

public class Route
{
    private City destination;
    private int cost;

    public City Destination
    {
        get { return destination; }
        set { destination = value; }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public Route(City destination, int cost)
    {
        Destination = destination;
        Cost = cost;
    }

    public override string ToString()
    {
        return $"{destination.Name}:{cost}";
    }
}
