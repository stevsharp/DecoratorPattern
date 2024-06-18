class ConcreteHome : AbstractHome
{
    public ConcreteHome() => Price = 0;

    public override void Create()
    {
        Console.WriteLine($"Original House is constructed.Price for this 10000$");
    }

}
