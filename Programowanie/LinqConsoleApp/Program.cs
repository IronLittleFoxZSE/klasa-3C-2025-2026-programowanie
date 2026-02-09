
using LinqConsoleApp;

//new Podstawa().Test();


List<Person> people = new List<Person>
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


//FILTRACJA

/*
select *
from people
where City == "Kielce"

*/

var fromKielce = people.Where(p => p.City == "Kielce");
Print("Osoby z Kielc (Where)", fromKielce);

/*
select *
from people
where Gender == Gender.Female //and Age > 18
*/

var onlyFemales = people.Where(p => p.Gender == Gender.Female /*&& p.Age > 18*/);
Print("Tylko kobiety", onlyFemales);



//SORTOWANIE

/*

select *
from people
order by Salary

*/

var orderedBySalary = people.OrderBy(p => p.Salary);
Print("Posortowane po wyp³acie", orderedBySalary);

/*

select *
from people
order by Salary desc

*/

var orderedBySalaryDesc = people.OrderByDescending(p => p.Salary);
Print("Posortowane po wyp³acie malej¹co", orderedBySalaryDesc);

/*

select *
from people
order by Age, Salary desc

*/

var orderByAgeAndSalaryDesc = people.OrderBy(p => p.Age).ThenByDescending(p => p.Salary);
Print("Posortowane po wieku i wyp³acie", orderByAgeAndSalaryDesc);


//AGREGACJA

/*

select count(*), avg(Salary), min(Age), max(Age), sum(Salary)
from people

*/

int countAll = people.Count();
var avgSalary = people.Average(p => p.Salary);
var minAge = people.Min(p => p.Age);
var maxAge = people.Max(p => p.Age);
var totalSalary = people.Sum(p => p.Salary);
Console.WriteLine($"\nAGREGACJE: count={countAll}, avgSalary={avgSalary:F2}, minAge={minAge}, maxAge={maxAge}, totalSalary={totalSalary:F0}");


//ELEMENTY

/*
select *
from people
where city == "Kielce"
limit 1
*/

var firstFromKielce = people.Where(p => p.City == "Kielce").First();
Console.WriteLine($"\nFirst (z Kielc): {firstFromKielce}");

/*
select *
from people
where city == "Poznan"
Limit 1
*/

try
{
    var firstFromPoznan = people.Where(p => p.City == "Poznan").First();
    Console.WriteLine($"\nFirst (z Poznan): {firstFromPoznan}");
}
catch (Exception)
{

}

/*
select *
from people
where city == "Poznan"
Limit 1
*/

var firstFromPoznanV2 = people.Where(p => p.City == "Poznan").FirstOrDefault();
if (firstFromPoznanV2 != null)
    Console.WriteLine($"\nFirst (z Poznan): {firstFromPoznanV2}");


/*
select *
from people
where city == "Kielce"
order by Id desc //z³e podejœcie
limit 1
*/

var lastFromKielce = people.Where(p => p.City == "Kielce").LastOrDefault();
if (lastFromKielce != null)
    Console.WriteLine($"\nLast (z Kielce): {lastFromKielce}");

//SPRAWDZANIE WARUNKÓW

var anyFromKrakow = people.Any(p => p.City == "Kraków");
var allAdults = people.All(p => p.Age >= 18);


//KONWERSJE

/*
select FirstName
from people

*/

var listOfNames = people.Select(p => p.FirstName);
Print("Kolekcja imion", listOfNames);


/*
select FirstName, Age
from people

*/

IEnumerable<BoxFirstNameAndAge> listOfNameAndAge = people.Select(p => new BoxFirstNameAndAge() {FirstName = p.FirstName, Age = p.Age });
Print("Kolekcja imion i lat", listOfNameAndAge);


/*
select FirstName + " " + LastName as Name, Age, City
from people

*/

var listOfNameAndAgeAndCity = people.Select(p=> new { Name = p.FirstName + " " + p.LastName, Age = p.Age, City = p.City });

void Print<T>(string title, IEnumerable<T> data)
{
    Console.WriteLine($"\n=== {title} ===");
    foreach (var item in data)
        Console.WriteLine(item);
}

class BoxFirstNameAndAge
{
    public string FirstName { get; init; } = default!;
    public int Age { get; init; }

    public override string ToString()
            => $"{FirstName}, {Age} lat";
}
