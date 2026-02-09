using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticalTasksConsoleApp;

/*
========================================
== POZIOM 1 – PODSTAWOWY ==
========================================

1. ZnajdŸ wszystkie osoby z Krakowa.
2. ZnajdŸ osoby pe³noletnie.
3. Posortuj osoby po wieku rosn¹co.
4. Posortuj osoby po nazwisku malej¹co.
5. Wypisz tylko imiê i nazwisko ka¿dej osoby.
6. Wypisz tylko miasta bez duplikatów.
7. Oblicz liczbê osób z Warszawy.
8. Oblicz œredni¹ pensjê wszystkich osób.
9. ZnajdŸ najm³odsz¹ osobê.
10. SprawdŸ, czy jest ktoœ z Gdañska.


========================================
== POZIOM 2 – ŒREDNI ==
========================================

11. Posortuj osoby po mieœcie, a w ramach miasta po pensji malej¹co.
12. ZnajdŸ osoby w wieku od 25 do 35 lat (w³¹cznie).
13. Oblicz sumê pensji osób z Kielc.
14. ZnajdŸ pierwsz¹ osobê, której pensja jest wiêksza ni¿ 10 000.
15. ZnajdŸ ostatni¹ osobê w kolejnoœci alfabetycznej po nazwisku.
16. Wygeneruj dane osób w formacie: "Imiê Nazwisko (Miasto)".
17. SprawdŸ, czy wszyscy maj¹ co najmniej 18 lat.
18. Policz, ile jest kobiet.
19. ZnajdŸ osoby, które zarabiaj¹ wiêcej ni¿ œrednia pensja.
20. ZnajdŸ najstarsz¹ osobê z Krakowa.


========================================
== POZIOM 3 – ZAAWANSOWANY ==
========================================

22. ZnajdŸ osoby, które maj¹ skill "C#".
23. ZnajdŸ osoby, które maj¹ co najmniej trzy skille.
24. ZnajdŸ osoby z Warszawy, posortuj je po wieku malej¹co i wypisz tylko ich imiê, nazwisko, wiek i pensjê.
25. SprawdŸ, czy ktoœ ma skill "Azure".
26. SprawdŸ, czy wszyscy zarabiaj¹ co najmniej 4000.
27. ZnajdŸ osobê o najwiêkszej pensji.
28. ZnajdŸ osobê o najmniejszej pensji.
29. Wypisz osoby, które maj¹ taki sam wiek jak najstarsza osoba.


========================================
== POZIOM 4 – EKSTRA / DLA CHÊTNYCH ==
========================================

32. Posortuj osoby wed³ug liczby posiadanych skilli.
33. Podziel osoby na dwie listy: zarabiaj¹cych przynajmniej 8000 oraz zarabiaj¹cych mniej ni¿ 8000.
35. Przyporz¹dkuj ka¿d¹ osobê do przedzia³u wiekowego (np. 20–29, 30–39, 40–49) i wypisz osoby z ka¿dego przedzia³u.

*/

internal class Task1
{
    void Print<T>(string title, IEnumerable<T> data)
    {
        Console.WriteLine($"\n=== {title} ===");
        foreach (var item in data)
            Console.WriteLine(item);
    }

    public void DoTasks()
    {
        var people = new List<Person>
        {
            new Person() { Id=1, FirstName="Anna",  LastName="Nowak",    Age=29, Gender=Gender.Female, City="Kielce", Salary=8200m,  Skills=["C#", "LINQ", "SQL"] },
            new() { Id=2, FirstName="Marek", LastName="Kowalski", Age=43, Gender=Gender.Male,   City="Warszawa", Salary=15000m, Skills=["Azure", "C#", "DevOps"] },
            new() { Id=3, FirstName="Ewa",   LastName="Wiœniewska",Age=35, Gender=Gender.Female, City="Kraków", Salary=9800m,  Skills=["JavaScript", "React"] },
            new() { Id=4, FirstName="Jan",   LastName="Zieliñski", Age=43, Gender=Gender.Male,   City="Gdañsk", Salary=12000m, Skills=["C#", "SQL"] },
            new() { Id=5, FirstName="Ola",   LastName="Maj",       Age=26, Gender=Gender.Female, City="Kielce", Salary=7200m,  Skills=["Python", "ML"] },
            new() { Id=6, FirstName="Piotr", LastName="Lewandowski",Age=37,Gender=Gender.Male,   City="Warszawa", Salary=13400m, Skills=["C#", "LINQ", "Azure"] },
            new() { Id=7, FirstName="Iga",   LastName="Kowal",     Age=31, Gender=Gender.Female, City="Kraków", Salary=9900m,  Skills=["Go", "Kubernetes"] },
            new() { Id=8, FirstName="Tomek", LastName="Sikora",    Age=29, Gender=Gender.Male,   City="Kielce", Salary=8800m,  Skills=["C#", "MAUI", "Bluetooth"] },
        };

        // === POZIOM 1 ===

        // Zadanie 1
        var q1 = people.Where(p => p.City == "Kraków");
        Print("Zadanie 1", q1);


    }
}
