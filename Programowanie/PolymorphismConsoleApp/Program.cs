

using PolymorphismConsoleApp;
using System.Runtime.Intrinsics.Arm;

Rectangle rectangle = new Rectangle(5, 9);

rectangle.ShowInfo();

Trapeze trapeze = new Trapeze(15, 25, 17, 16, 4);

trapeze.ShowInfo();

Square square = new Square(4);

square.ShowInfo();

Triangle triangle = new Triangle(3, 4, 5, 6);
triangle.ShowInfo();

//Figure figure = new Figure();

/*
Test1(square);
Test2(rectangle);
*/
/*
Test3(square);
Test3(rectangle);
Test3(trapeze);
//Test3(triangle);
*/

Test4(square);
Test4(rectangle);
Test4(trapeze);
Test4(triangle);

/*
void Test1(Square s)
{
    Console.WriteLine($"Obwód: {s.GetPerimieter()}");
}

void Test2(Rectangle r)
{
    Console.WriteLine($"Obwód: {r.GetPerimieter()}");
}
*/
/*
void Test3(Trapeze t)
{
    Console.WriteLine();
    Console.WriteLine($"Obwód: {t.GetPerimieter()}");
    Console.WriteLine($"Pole: {t.GetArea()}");

}
*/

void Test4(Figure f)
{
    Console.WriteLine();
    Console.WriteLine($"Obwód: {f.GetPerimieter()}");
    Console.WriteLine($"Pole: {f.GetArea()}");

}

Cat cat = new Cat();
cat.SaveToFile();

triangle.SaveToFile();
square.SaveToFile();

Save(triangle);
Save(square);
Save(cat);

void Save(IWorkOnFiles x)
{
    x.SaveToFile();
}

