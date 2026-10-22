using System;

public class Route
{
    private City _destination;
    private int _cost;

    public Route(City _destination, int _cost)
    {
        Destination = _destination;
        Cost = _cost;
    }

    public City Destination
    {
        get { return _destination; }
        set { _destination = value; }
    }

    public int Cost
    {
        get { return _cost; }
        set { _cost = value; }
    }

    public override string ToString()
    {
        return $"{_destination.Name}:{_cost}";
    }
}
