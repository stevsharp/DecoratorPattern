public class PaintDecorator : AbstractDecorator
{
    public PaintDecorator(AbstractHome abstractHome) : base(abstractHome)
    {
    }

    public override void Create()
    {
        base.Create();

        PaintHome();
    }

    private void PaintHome()
    {
        Console.WriteLine($"--Painting done.Pay additional ${Price} : for it.");
    }
}