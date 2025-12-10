

using GenericTypesConsoleApp;
using System.Numerics;

ContainerInt containerInt = new ContainerInt(42);
containerInt.Show();

ContainerInt secondContainerInt;
secondContainerInt = containerInt;


ContainerString containerString = new ContainerString("Ala ma kota");
containerString.Show();

Container<double> container = new Container<double>(3.14);
container.Show();

Container<string> secondContainer = new Container<string>("Ala ma kota");
secondContainer.Show();

//secondContainer = container;

//------------------------------------------------------------------------------

Console.WriteLine($"Wartość maksymalna: {GetMaxInt(2, 8)}");
Console.WriteLine($"Wartość maksymalna: {GetMaxDouble(2.0, 1.8)}");

Console.WriteLine($"Wartość maksymalna: {GetMaxGen<int>(2, 8)}");
Console.WriteLine($"Wartość maksymalna: {GetMaxGen/*<double>*/(2.0, 1.8)}");

Test t1 = new Test() { MyProperty = 5 };
Test t2 = new Test() { MyProperty = 4 };

//Console.WriteLine($"Wartość maksymalna: {GetMaxGen/*<Test>*/(t1, t2)}");

Action firstAction = null;
firstAction = TestMethod;
firstAction = () => { Console.WriteLine("To jest funkcja testowa"); };
firstAction = () => Console.WriteLine("To jest funkcja testowa"); 

if (firstAction is not null)
    firstAction();

Action<int> secondAction;
secondAction = TestSecondMethod;
secondAction = (int value) => { Console.WriteLine($"To jest funkcja testowa z parametrem o wartości {value}"); };
secondAction = (int value) => Console.WriteLine($"To jest funkcja testowa z parametrem o wartości {value}");
secondAction = (value) => Console.WriteLine($"To jest funkcja testowa z parametrem o wartości {value}");
if (secondAction is not null)
    secondAction(25);

Func<double> firstFunc;
firstFunc = TestThirdMethod;
firstFunc = () => { return 4.7; };
firstFunc = () =>  4.7;
double x;
if (firstFunc is not null)
    x = firstFunc();

Func<string, float> secondFunc;
secondFunc = TestFourthMethod;
secondFunc = (string text) => { return float.Parse(text); };
secondFunc = (string text) => float.Parse(text);
secondFunc = (text) => float.Parse(text);
if (secondFunc is not null)
    x = secondFunc("123");


Console.WriteLine($"Wartość maksymalna: {GetMax<int>(2, 8, cmpInt)}");
Console.WriteLine($"Wartość maksymalna: {GetMax<int>(2,
                                                     8,
                                                     (x, y) => x > y
                                                     )}");
Console.WriteLine($"Wartość maksymalna: {GetMax(2.8, 1.8, cmpDouble)}");
Console.WriteLine($"Wartość maksymalna: {GetMax(2.8, 1.8, (x, y) => x > y)}");
Console.WriteLine($"Wartość maksymalna: {GetMax(2.8, 2, (x, y) => x > 2 * y)}");

Console.WriteLine($"Wartość maksymalna: {GetMax/*<Test>*/(t1, t2, cmpTest).MyProperty}");
Console.WriteLine($"Wartość maksymalna: {GetMax(t1,
                                                t2,
                                                (x, y) => x.MyProperty > y.MyProperty
                                                ).MyProperty}");

bool cmpInt(int x, int y)
{
    return x > y;
}

bool cmpDouble(double x, double y)
{
    return x > y;
}

bool cmpTest(Test x,  Test y)
{
    return x.MyProperty > y.MyProperty;
}

T GetMax<T>(T a, T b, Func<T, T, bool> cmp)
{
    T max;

    if (cmp(a, b))
        max = a;
    else
        max = b;

    return max;
}

T GetMaxGen<T>(T a, T b) where T : INumber<T>   //class, INumber<T>, new()
{
    T max;

    if (a > b)
        max = a;
    else
        max = b;

    return max;
}

int GetMaxInt(int a, int b)
{
    int max;

    if (a > b)
        max = a;
    else
        max = b;

    return max;
}

double GetMaxDouble(double a, double b)
{
    double max;

    if (a > b)
        max = a;
    else
        max = b;

    return max;
}

void TestMethod()
{
    Console.WriteLine("To jest funkcja testowa");
}

void TestSecondMethod(int value)
{
    Console.WriteLine($"To jest funkcja testowa z parametrem o wartości {value}");
}

double TestThirdMethod()
{
    return 4.7;
}

float TestFourthMethod(string text)
{
    return float.Parse(text);
}

class Test//: INumber<Test>
{
    public int MyProperty { get; set; }
}