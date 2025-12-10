using System.Xml.Linq;

namespace PolymorphismConsoleApp;

internal class Triangle: Figure
{
    private int sideA,sideB,sideC;
    //protected string name;
    protected double height;

    public Triangle(int a, int b, int c, int h)
    {
        sideA = a;
        sideB = b;
        sideC = c;
        height = h;
        name = "trójkąt";
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Obiekt {name}.");
        Console.WriteLine($"Bok a = {sideA}");
        Console.WriteLine($"Bok b = {sideB}");
        Console.WriteLine($"Bok c = {sideC}");
        Console.WriteLine($"Obwód = {GetPerimieter()}");
        Console.WriteLine($"Pole = {GetArea()}");
    }

    public override double GetPerimieter()
    {
        return sideA + sideB + sideC;
    }

    public /*virtual*/ override double GetArea()
    {
        return sideA * height / 2;
    }

    public override void SaveToFile()
    {

    }
}
