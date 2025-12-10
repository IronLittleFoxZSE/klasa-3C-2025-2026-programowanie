namespace PolymorphismConsoleApp;

internal class Rectangle : Trapeze
{
    public Rectangle(double a, double b) : base(a, a, b, b, b)
    {
        name = "Prostokąt";
    }

    public override double GetArea()
    {
        return sideA * sideC;
    }
}
