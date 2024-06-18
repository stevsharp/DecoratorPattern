public class FloorDecorator : AbstractDecorator
{
    public FloorDecorator(AbstractHome abstractHome) : base(abstractHome)
    {
    }

    public override void Create()
    {
        base.Create();

        AddFloor();
    }

    private void AddFloor()
    {
        Console.WriteLine($"-Additional Floor added.Pay additional {Price}:  $ for it.");
    }
}
