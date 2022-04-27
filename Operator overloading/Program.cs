State England = new State { Area = 1500000, Population = 10000 };
State Amsterdam = new State { Area = 405000, Population = 200 };
State EngAmst = England + Amsterdam;
Console.WriteLine(EngAmst.Area);
Console.WriteLine(EngAmst.Population);

if (England > Amsterdam)
{
    Console.WriteLine("England is bigger than Amsterdam");
}
else
{
    Console.WriteLine("Amsterdam is bigger tham England");
}


class State
{
    public decimal Population { get; set; }
    public decimal Area { get; set; }
    public static State operator +(State firstContry, State secondContry)
    {
        return new State
        {
            Area = firstContry.Area + secondContry.Area,
            Population = firstContry.Population + secondContry.Population
        };
    }
    public static bool operator <(State firstContry, State secondCountry)
    {
        return firstContry.Population < secondCountry.Population;
    }
    public static bool operator >(State firstContry, State secondCountry)
    {
        return firstContry.Population > secondCountry.Population;
    }
}