
void ErrorsV1()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int result = 0;

    if (secondNumber != 0)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Wynik: {result}");
    }
    else
    {
        Console.WriteLine("Nie dziel przez zero!!!!");
    }
}

int? Div(int a, int b)
{
    if (b != 0)
    {
        int r;
        r = a / b;
        return r;
    }
    else
        return null;
}

void ErrorsV2()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int? result = 0;

    result = Div(firstNumber, secondNumber);
    if (result != null)
        Console.WriteLine($"Wynik: {result}");
    else
        Console.WriteLine("Nie dziel przez zero!!!!");
}

bool Div2(int a, int b, out int r)
{
    r = 0;
    if (b != 0)
    {
        r = a / b;
        return true;
    }
    else
        return false;
}

void ErrorsV3()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int result = 0;

    if (Div2(firstNumber, secondNumber, out result))
        Console.WriteLine($"Wynik: {result}");
    else
        Console.WriteLine("Nie dziel przez zero!!!!");
}

string Div4(int a, int b, out int r)
{
    r = 0;
    if (a < 0)
    {
        return "Pierwiastek ujemny";
    }

    if (b == 0)
    {

        return "Dzielenie przez zero";
    }

    r = a / b + (int)Math.Sqrt(a);
    return "";
}

void ErrorsV4()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int result = 0;

    string error = Div4(firstNumber, secondNumber, out result);
    if (error == "")
        Console.WriteLine($"Wynik: {result}");
    /*
     else if (error == "Pierwiastek ujemny")
        Console.WriteLine("Błąd: Pierwiastek ujemny");
    else if (error == "Dzielenie przez zero")
        Console.WriteLine("Błąd: Dzielenie przez zero");
    */
    else
        Console.WriteLine($"Błąd: {error}");
}

void ErrorsV5()
{
    bool dalej;
    do
    {
        dalej = true;
        Console.WriteLine("Podaj pierwszą liczbę:");
        string strFirstNumber = Console.ReadLine();
        int firstNumber = int.Parse(strFirstNumber);

        int secondNumber;

        Console.WriteLine("Podaj drugą liczbę:");
        secondNumber = int.Parse(Console.ReadLine());

        int result = 0;
        try
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"Wynik: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
            dalej = false;
        }

    } while (!dalej);
}

int Div6(int a, int b)
{
    int r;
    r = a / b;
    return r;
}

void ErrorsV6()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int result = 0;
    try
    {
        result = Div6(firstNumber, secondNumber);
        Console.WriteLine($"Wynik: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd: {ex.Message}");
    }
}


int Div7(int a, int b)
{
    int r = 0;
    if (a < 0)
    {
        throw new Exception("Pierwiastek ujemny");
    }
    r = a / b + (int)Math.Sqrt(a);
    return r;
}

void ErrorsV7()
{
    Console.WriteLine("Podaj pierwszą liczbę:");
    string strFirstNumber = Console.ReadLine();
    int firstNumber = int.Parse(strFirstNumber);

    int secondNumber;

    Console.WriteLine("Podaj drugą liczbę:");
    secondNumber = int.Parse(Console.ReadLine());

    int result = 0;

    try
    {
        result = Div7(firstNumber, secondNumber);
        Console.WriteLine($"Wynik: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd: {ex.Message}");
    }
}

int Div8(int a, int b)
{
    int r = 0;
    if (a < 0)
    {
        throw new Exception("Pierwiastek ujemny");
    }
    r = a / b + (int)Math.Sqrt(a);
    return r;
}

void ErrorsV8()
{
    bool dalej;
    do
    {
        dalej = true;
        Console.WriteLine("Podaj pierwszą liczbę:");
        string strFirstNumber = Console.ReadLine();
        int firstNumber = int.Parse(strFirstNumber);

        int secondNumber;

        Console.WriteLine("Podaj drugą liczbę:");
        secondNumber = int.Parse(Console.ReadLine());

        int result = 0;
        try
        {
            result = Div8(firstNumber, secondNumber);
            Console.WriteLine($"Wynik: {result}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
            //throw;
            throw new ArgumentNullException("Moja wiadomość - dzielenie przez zero", ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
            dalej = false;
        }

    } while (!dalej);
}

ErrorsV8();