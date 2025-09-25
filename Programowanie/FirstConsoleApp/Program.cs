Console.Write("Hello, World!\n");
Console.WriteLine("Hello, World!");

string name = "Jan";
string surname = "Kowalski";
Console.WriteLine("Witaj " + name + " " + surname + " tutaj!!!!");
Console.WriteLine("Witaj {0} {1} tutaj!!!!", name, surname);
Console.WriteLine($"Witaj {name} {surname} tutaj!!!!");

Console.WriteLine("Prędkość to km\\h");
Console.WriteLine(@"Prędkość to km\h");

int firstNumber = 5;
int secondNumber = firstNumber;
secondNumber++;
Console.WriteLine($"Pierwsza liczba to {firstNumber}");
Console.WriteLine($"Druga liczba to {secondNumber}");

//-----------------------------------------------------

//przekazywanie przez wartość
void ParametrTest_v1(int p)
{
    Console.WriteLine($"Parametr w ParametrTest_v1 {p}");
    p++;
    Console.WriteLine($"Parametr w ParametrTest_v1 {p}");
}

//przekazywanie przez referencję
void ParametrTest_v2(ref int p)
{
    Console.WriteLine($"Parametr w ParametrTest_v2 {p}");
    p++;
    Console.WriteLine($"Parametr w ParametrTest_v2 {p}");
}

//przekazywanie przez referencję
void ParametrTest_v3(out int p)
{
    //Console.WriteLine($"Parametr w ParametrTest_v3 {p}");
    p = 19;
    Console.WriteLine($"Parametr w ParametrTest_v3 {p}");
}

firstNumber = 15;
Console.WriteLine($"firstNumber przed {firstNumber}");
ParametrTest_v1(firstNumber);
Console.WriteLine($"firstNumber po {firstNumber}");
//ParametrTest_v1(99);

firstNumber = 15;
Console.WriteLine($"firstNumber przed {firstNumber}");
ParametrTest_v2(ref firstNumber);
Console.WriteLine($"firstNumber po {firstNumber}");
//ParametrTest_v2(ref 99); //BŁAD

int thirdNumber;
ParametrTest_v3(out thirdNumber);
Console.WriteLine($"thirdNumber po {thirdNumber}");
//ParametrTest_v3(out 99); //BŁAD

//-----------------------------------------------------

string firstStrNumber = "15";

int firstConvertNumber = int.Parse(firstStrNumber);
Console.WriteLine($"Po konwersji {firstConvertNumber}");

if (int.TryParse(firstStrNumber, out int secondConvertNumber))
    Console.WriteLine($"Udało się skonwertować {secondConvertNumber}");

