Target target = new Adapter(new Adaptee());
target.Request();

public class Adapter : Target
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public override void Request()
    {
        _adaptee.SpecificRequest();
    }
}
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Called SpecificRequest()");
    }
}

public abstract class Target
{
    public abstract void Request();
}