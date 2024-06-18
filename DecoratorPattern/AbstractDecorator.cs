public abstract class AbstractDecorator : AbstractHome
{
    protected AbstractHome AbstractHome { get; set; }

    public AbstractDecorator(AbstractHome abstractHome)
    {
        AbstractHome = abstractHome;

        Price = 0;
    }

    public override void Create()
    {
        AbstractHome.Create();
    }
}
