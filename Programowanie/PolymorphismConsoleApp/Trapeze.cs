namespace PolymorphismConsoleApp;

internal class Trapeze : Figure
{
    //protected string name;
    protected double sideA, sideB, sideC, sideD;
    protected double height;

    public Trapeze(double a, double b, double c, double d, double h)
    {
        sideA = a;
        sideB = b;
        sideC = c;
        sideD = d;
        height = h;
        name = "Trapez";
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Obiekt {name}.");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Bok b = {sideB}");
        Console.WriteLine($"Bok c = {sideC}");
        Console.WriteLine($"Bok d = {sideD}");
        Console.WriteLine($"Obwód = {GetPerimieter()}");
        Console.WriteLine($"Pole = {GetArea()}");
    }

    public override double GetPerimieter()
    {
        return sideA + sideB + sideC + sideD;
    }

    public override double GetArea()
    {
        return (sideA + sideB) * height / 2;
    }

    public override void SaveToFile()
    {

    }
}


/*
                  b
        ---------------------
   c   /                      \    d
      /                        \
      --------------------------
                a
*/