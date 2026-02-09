using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticalTasksConsoleApp;

/*
========================================
== ZESTAW ZADAÑ – LINQ – KLASA ORDER ==
==      (zadania ca³kowicie nowe)     ==
========================================

POZIOM 1 – PODSTAWOWY
1. Wypisz wszystkie zamówienia o statusie „New”.
2. SprawdŸ, czy istnieje zamówienie na produkt “Laptop”.
3. Wypisz zamówienia z ostatnich 30 dni.

POZIOM 2 – ŒREDNI
4. Wygeneruj listê tekstów w formacie: "Klient ? wartoœæ zamówienia".
5. ZnajdŸ zamówienia, w których nazwa produktu zawiera literê „o”.
6. ZnajdŸ zamówienia maj¹ce wartoœæ wiêksz¹ ni¿ 1000 i status inny ni¿ „Cancelled”.
7. SprawdŸ, czy wszystkie zamówienia pochodz¹ z bie¿¹cego roku.

POZIOM 3 – ZAAWANSOWANY
8. ZnajdŸ zamówienia, gdzie klient zamówi³ wiêcej ni¿ jeden ró¿ny produkt (czyli klient pojawia siê wiêcej ni¿ raz z ró¿nymi produktami).
9. Wypisz klientów wraz z liczb¹ dni, które minê³y od ich najstarszego zamówienia.
10. Wypisz wszystkie unikalne pary (Klient, Produkt).
11. ZnajdŸ klientów, którzy maj¹ co najmniej jedno zamówienie w statusie „Cancelled” ORAZ co najmniej jedno w statusie „Delivered”.
12. Wypisz zamówienia, których wartoœæ mieœci siê pomiêdzy 1000 a 3000 z³ i zosta³y z³o¿one w ci¹gu ostatnich 14 dni.
13. ZnajdŸ klientów, którzy zamawiali ten sam produkt w ró¿nych terminach.
14. ZnajdŸ zamówienia, w których cena jednostkowa produktu jest wy¿sza ni¿ ³¹czna wartoœæ jakiegokolwiek innego zamówienia.
*/

internal class Task2
{
    void Print<T>(string title, IEnumerable<T> data)
    {
        Console.WriteLine($"\n=== {title} ===");
        foreach (var item in data)
            Console.WriteLine(item);
    }

    public void DoTask()
    {
        var orders = new List<Order>
        {
            // Anna
            new() { Id = 1,  Customer="Anna", Product="Laptop",    Quantity=1, PricePerItem=4500m, OrderDate=DateTime.Today.AddDays(-20), Status=OrderStatus.New },
            new() { Id = 2,  Customer="Anna", Product="Myszka",    Quantity=2, PricePerItem=75m,   OrderDate=DateTime.Today.AddDays(-5),  Status=OrderStatus.Delivered },
            new() { Id = 3,  Customer="Anna", Product="Laptop",    Quantity=1, PricePerItem=4600m, OrderDate=DateTime.Today.AddDays(-2),  Status=OrderStatus.Shipped },

            // Piotr
            new() { Id = 4,  Customer="Piotr", Product="Monitor",   Quantity=1, PricePerItem=900m,  OrderDate=DateTime.Today.AddDays(-35), Status=OrderStatus.Delivered },
            new() { Id = 5,  Customer="Piotr", Product="Klawiatura",Quantity=1, PricePerItem=120m,  OrderDate=DateTime.Today.AddDays(-10), Status=OrderStatus.Cancelled },

            // Ewa
            new() { Id = 6,  Customer="Ewa", Product="Tablet",      Quantity=1, PricePerItem=1500m, OrderDate=DateTime.Today.AddDays(-8),  Status=OrderStatus.Processing },
            new() { Id = 7,  Customer="Ewa", Product="S³uchawki",   Quantity=2, PricePerItem=300m,  OrderDate=DateTime.Today.AddDays(-3),  Status=OrderStatus.New },

            // Ola
            new() { Id = 8,  Customer="Ola", Product="Laptop",      Quantity=1, PricePerItem=4200m, OrderDate=DateTime.Today.AddDays(-40), Status=OrderStatus.Delivered },
            new() { Id = 9,  Customer="Ola", Product="Monitor",     Quantity=3, PricePerItem=850m,  OrderDate=DateTime.Today.AddDays(-12), Status=OrderStatus.Processing },
            new() { Id = 10, Customer="Ola", Product="Laptop",      Quantity=2, PricePerItem=4100m, OrderDate=DateTime.Today.AddDays(-4),  Status=OrderStatus.New },

            // Jan
            new() { Id = 11, Customer="Jan", Product="Monitor",     Quantity=2, PricePerItem=780m,  OrderDate=DateTime.Today.AddDays(-18), Status=OrderStatus.Delivered },
            new() { Id = 12, Customer="Jan", Product="Monitor",     Quantity=1, PricePerItem=820m,  OrderDate=DateTime.Today.AddDays(-1),  Status=OrderStatus.Shipped },

            // Iga
            new() { Id = 13, Customer="Iga", Product="Tablet",      Quantity=1, PricePerItem=1600m, OrderDate=DateTime.Today.AddDays(-7),  Status=OrderStatus.Processing },
            new() { Id = 14, Customer="Iga", Product="Tablet",      Quantity=2, PricePerItem=1550m, OrderDate=DateTime.Today.AddDays(-2),  Status=OrderStatus.Delivered },

            // Kasia
            new() { Id = 15, Customer="Kasia", Product="Drukarka",  Quantity=1, PricePerItem=700m,  OrderDate=DateTime.Today.AddDays(-1),  Status=OrderStatus.New },
            new() { Id = 16, Customer="Kasia", Product="Laptop",    Quantity=1, PricePerItem=4300m, OrderDate=DateTime.Today.AddDays(-28), Status=OrderStatus.Delivered }
        };
    }
    }
