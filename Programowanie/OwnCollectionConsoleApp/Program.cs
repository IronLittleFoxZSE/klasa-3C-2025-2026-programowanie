

using OwnCollectionConsoleApp;

OwnCollection<int> ownCollection = new OwnCollection<int>(10);

ownCollection.Add(7457);
ownCollection.Add(7458);

Console.WriteLine("Kolekcja ma elementów: " + ownCollection.Count);


IEnumerator<int> enumerator = ownCollection.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

foreach (int item in ownCollection)
{
    Console.WriteLine(item);
}