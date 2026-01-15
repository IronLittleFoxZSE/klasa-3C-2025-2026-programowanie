

//typ nazwa[rozmiar]; // c++
//nazwa[numerKomórki] = wartoœæ;

//typ[] nazwa = new typ[rozmiar];  //c#
//nazwa[numerKomórki] = wartoœæ;

using System.Collections;
using System.IO.Compression;

int[] tab1 = new int[6];
tab1[5] = 78;

tab1 = new int[99];

int[] tab2 = { 1, 8, 9, 5 };
int[] tab3 = [ 1, 8, 9, 5 ]; //od .net8.0 i C#12

for(int i = 0; i < tab2.Length; i++)
    Console.WriteLine(tab2[i]);

//tab2[9] = 5; //b³¹d

List<int> firstList = new List<int>();
firstList.Add(5);
firstList.Add(6);
firstList.Add(87);

Console.WriteLine("Zawartoœæ listy:");
for (int i = 0; i < firstList.Count; i++)
    Console.WriteLine(firstList[i]);

firstList[1] = 54;
//firstList[7] = 14; //B³¹d nie ma indeksu

firstList.Add(65);
Console.WriteLine("Zawartoœæ listy:");
for (int i = 0; i < firstList.Count; i++)
    Console.WriteLine(firstList[i]);

firstList.Clear();

int number;
do
{
    Console.WriteLine("Podaj liczbê:");
    number = int.Parse(Console.ReadLine());
    firstList.Add(number);
} while (number != 0);

Console.WriteLine("Zawartoœæ listy z liczbami u¿ytkownika:");
//for (int i = 0; i < firstList.Count; i++)
foreach(int num in firstList)
    Console.WriteLine(num);

//wersja 1
List<string> words = new List<string>();
List<string> definictions = new List<string>();
words.Add("Kwadrat");
definictions.Add("czworok¹t foremny, czyli z przystaj¹cymi bokami i k¹tami wewnêtrznymi (a st¹d prostymi)");

words.Add("Romb");
definictions.Add("rzadziej ukoœnik – czworok¹t o bokach równej d³ugoœci");

Console.WriteLine("S³ownik wersja 1");
for(int i = 0; i < words.Count; i++)
    Console.WriteLine($"{words[i]} - {definictions[i]}");

//wersja 2
List<WordDefinition> wordDefinitions = new List<WordDefinition>();
wordDefinitions.Add(new WordDefinition() { Word = "Kwadrat", Definition = "czworok¹t foremny, czyli z przystaj¹cymi bokami i k¹tami wewnêtrznymi (a st¹d prostymi)" });
wordDefinitions.Add(new WordDefinition() { Word = "Romb", Definition = "rzadziej ukoœnik – czworok¹t o bokach równej d³ugoœci" });

WordDefinition wordDefinition = new WordDefinition() { Word = "Kwadrat", Definition = "czworok¹t foremny, czyli z przystaj¹cymi bokami i k¹tami wewnêtrznymi (a st¹d prostymi)" };
wordDefinitions.Add(wordDefinition);
wordDefinition.Word = "Inny";

Console.WriteLine("S³ownik wersja 2");
foreach (WordDefinition item in wordDefinitions)
    Console.WriteLine($"{item.Word} - {item.Definition}");

//wersja 3

Dictionary<string, string> kolekcja = new Dictionary<string, string>();
kolekcja.Add("Prostok¹t", "definicja prostok¹ta");
kolekcja.Add("Kwadrat", "definicja kwadratu");

if (kolekcja.ContainsKey("Romb"))
{
    kolekcja["Romb"] = "nowa definicja rombu";
}
else
    kolekcja.Add("Romb", "definicja rombu");

kolekcja["Prostok¹t"] = "nowa definicja prostok¹ta";
kolekcja["Kwadrat"] = "nowa definicja kwadratu";

foreach (var item in kolekcja)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

class WordDefinition
{
    public string Word { get; set; }
    public string Definition { get; set; }
}

/*
1) Podstawy
T[] (tablica)

Jak przechowuje: ci¹g³y blok pamiêci o sta³ym rozmiarze.
Operacje: indeksowanie O(1), zmiana rozmiaru – brak (tworzenie nowej tablicy).
Uporz¹dkowanie: zachowuje kolejnoœæ.
Duplikaty: dozwolone.
Kiedy u¿ywaæ: sta³a liczba elementów, maksymalna wydajnoœæ i minimalny narzut; dostêp przez indeks.

List<T>

Jak przechowuje: dynamiczna tablica (automatyczne powiêkszanie).
Operacje: indeksowanie O(1), dodanie na koñcu amortyzacyjnie O(1), wstawki/usuñ w œrodku O(n), wyszukiwanie liniowe O(n) (chyba ¿e wczeœniej posortujesz i u¿yjesz BinarySearch).
Uporz¹dkowanie: zachowuje kolejnoœæ dodawania.
Duplikaty: dozwolone.
Kiedy u¿ywaæ: najczêstsza domyœlna kolekcja; gdy potrzebujesz listy o zmiennym rozmiarze.

LinkedList<T>

Jak przechowuje: dwukierunkowa lista wi¹zana.
Operacje: dodawanie/usuwanie maj¹c wêze³ O(1), wyszukiwanie O(n), brak indeksowania O(1).
Uporz¹dkowanie: zachowuje kolejnoœæ.
Duplikaty: dozwolone.
Kiedy u¿ywaæ: du¿o wstawek/usuniêæ w œrodku bez przesuwania pamiêci; rzadko w praktyce, bo List<T> bywa szybsza dziêki spójnoœci pamiêci.

2) S³owniki i mapy (klucz ? wartoœæ)
Dictionary<TKey,TValue>

Jak przechowuje: tablica z haszowaniem (hash table).
Operacje: dodaj/odczytaj/usuñ O(1) œrednio.
Uporz¹dkowanie: brak gwarancji kolejnoœci.
Duplikaty: klucze unikalne, wartoœci mog¹ siê powtarzaæ.
Kiedy u¿ywaæ: szybki dostêp po kluczu (lookup cache, indeksy).

SortedDictionary<TKey,TValue>

Jak przechowuje: drzewo BST (zbalansowane).
Operacje: O(log n) dla wstaw/odczyt/usuñ; ³atwy dostêp do zakresów.
Uporz¹dkowanie: posortowane po kluczu (komparer).
Kiedy u¿ywaæ: potrzebujesz danych w kolejnoœci lub operacji „range”.

SortedList<TKey,TValue>

Jak przechowuje: dwie posortowane tablice (klucze i wartoœci).
Operacje: odczyt po indeksie O(1), wyszukiwanie O(log n), wstawka O(n) (przesuniêcia).
Kiedy u¿ywaæ: ma³e/œrednie zbiory, czêsty odczyt, rzadsze wstawki, i dostêp po indeksie.

3) Zbiory (bez duplikatów)
HashSet<T>

Jak przechowuje: hash set.
Operacje: dodaj/sprawdŸ O(1) œrednio; przeciêcia/³¹cznie – efektywne.
Uporz¹dkowanie: brak.
Duplikaty: niedozwolone.
Kiedy u¿ywaæ: obecnoœæ elementu, operacje na zbiorach.

SortedSet<T>

Jak przechowuje: drzewo BST.
Operacje: O(log n); wspiera zakresy i kolejnoœæ.
Uporz¹dkowanie: posortowane.
Duplikaty: niedozwolone.
Kiedy u¿ywaæ: potrzebujesz zbioru z kolejnoœci¹ lub operacji zakresowych.

4) Kolejki i stosy (struktury FIFO / LIFO)
Queue<T>

Jak przechowuje: ko³owa kolejka (array-backed).
Operacje: Enqueue/Dequeue O(1) amortyzacyjnie.
Uporz¹dkowanie: FIFO.
Kiedy u¿ywaæ: buforowanie, przetwarzanie w kolejnoœci przyjœcia.

Stack<T>

Jak przechowuje: stos (array-backed).
Operacje: Push/Pop/Peek O(1).
Uporz¹dkowanie: LIFO.
Kiedy u¿ywaæ: nawigacja, rekurencja, „cofanie”.


 */