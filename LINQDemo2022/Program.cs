// See https://aka.ms/new-console-template for more information
using LINQDemo2022.Model;
using System.Linq;

// Alice Andělová P1
// Bořivoj Bohatý P1
// Ctirad Cudný P2
// Daniela Drozdová P2

// ALG, PRG, MAT, CJL

// https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/concepts/linq/
// https://www.tutorialsteacher.com/linq
// https://www.geeksforgeeks.org/linq-method-syntax/?ref=lbp

// Where: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.where?view=net-6.0 Podmínka
// Order: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.orderby?view=net-6.0 Sezaření Vzestupně
// OrderByDescending: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.orderbydescending?view=net-6.0 Sezaření zestupně 
// Select: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.select?view=net-6.0 Zakládá nový objekt
// GroupBy: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.groupby?view=net-6.0 Seskupí data ve tvaru <string, Class>
// Count: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.count?view=net-6.0 Počítá data
// Max: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.max?view=net-6.0 Největší hodnota
// Min: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.min?view=net-6.0 Nejnižší hodnota
// Take: https://docs.microsoft.com/cs-cz/dotnet/api/system.linq.enumerable.take?view=net-6.0 Vrací konkrétní počet hodnot



List<Mark> marks = new List<Mark> { 
    new Mark("Alice","Andělová", "P1", "ALG", 1, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "ALG", 3, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "PRG", 1, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "PRG", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "MAT", 2, new DateTime(2020,3,1)),
    new Mark("Bořivoj","Bohatý", "P1", "MAT", 3, new DateTime(2020,4,7)),
    new Mark("Ctirad","Cudný", "P2", "MAT", 3, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "MAT", 5, new DateTime(2020,1,2)),
    new Mark("Alice","Andělová", "P1", "MAT", 2, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "MAT", 4, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "PRG", 2, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "PRG", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "ALG", 4, new DateTime(2020,1,1)),
    new Mark("Bořivoj","Bohatý", "P1", "ALG", 4, new DateTime(2020,1,1)),
    new Mark("Ctirad","Cudný", "P2", "CJL", 2, new DateTime(2020,2,2)),
    new Mark("Daniela","Drozdová", "P2", "CJL", 5, new DateTime(2020,2,2)),
    new Mark("Alice","Andělová", "P1", "CJL", 1, new DateTime(2020,3,1)),
    new Mark("Bořivoj","Bohatý", "P1", "CJL", 3, new DateTime(2020,4,4)),
    new Mark("Ctirad","Cudný", "P2", "MAT", 1, new DateTime(2020,3,2)),
    new Mark("Daniela","Drozdová", "P2", "MAT", 5, new DateTime(2020,2,3))
};

// Seřaďte záznamy podle jména studenta

var res1 = marks.OrderBy(m => m.FirstName);
foreach (var x in res1)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Seřaďte záznamy podle data

var res2 = marks.OrderBy(m => m.Created);
foreach (var x in res2)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Seřaďte záznamy podle třídy sestupně

var res3 = marks.OrderByDescending(m => m.ClassName);
foreach (var x in res3)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Získejte jen známky studentky Alice

var res4 = marks.Where(a => a.FirstName == "Alice");
foreach (var x in res4)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Získejte jen známky z P1

var res5 = marks.Where(c => c.ClassName == "P1");
foreach (var x in res5)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Získejte jen známky z P1 seřazené podle příjmení studenta
var res6 = marks
    .OrderBy(m => m.LastName)
    .Where(c => c.ClassName == "P1");
foreach (var x in res5)
{
    Console.WriteLine(x);
}
Console.WriteLine("----------------------------------------------------------");

// Získejte jen známky z P1, nezískávejte ale jiné informace kromě příjmení a známky

var res7 = marks
    .Where(c => c.ClassName == "P1")
    .Select(a => new Mark1VM { LastName = a.LastName, Value = a.Value});
foreach (var x in res5)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
Console.WriteLine("----------------------------------------------------------");

// Kolik známek vlastně dostala dohromady třída P2?

var res8 = marks
    .Where(c => c.ClassName == "P2")
    .Count();
Console.WriteLine(res8);
Console.WriteLine("----------------------------------------------------------");

// Získejte průměr všech známek studentky Alice

var avarage = marks
    .Where(x => x.FirstName == "Alice")
    .Average(x => x.Value);

var avarage0 = marks
    .Where(x => x.FirstName == "Alice")
    .Select(m => new Decimal(m.Value))
    .Average();

Console.WriteLine(avarage);
Console.WriteLine(avarage0);
Console.WriteLine("----------------------------------------------------------");

// Získejte známky z jednotlivých předmětů studentky Alice

var alice = marks
    .Where(a => a.FirstName == "Alice")
    .GroupBy(x => x.Subject);

foreach (var x in alice)
{
    Console.WriteLine("- " + x.Key);
    foreach(var y in x.OrderBy(m => m.Value).ToList())
    {
        Console.WriteLine(y.Value);
    }
}
Console.WriteLine("----------------------------------------------------------");

// Získejte průměrné známky všech studentů

var students = marks
    .GroupBy(x => x.LastName)
    .Select(x => new Mark1VM {
        LastName = x.Key,
        Value = (int)x.Average(y => y.Value) 
    });

foreach (var x in students)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
Console.WriteLine("----------------------------------------------------------");

// Kolik známek dostala jaká třída?

var classes = marks
    .GroupBy(x => x.ClassName)
    .Select(x => new Mark1VM { LastName = x.Key, Value = (int)x.Count() });

foreach (var x in classes)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
Console.WriteLine("----------------------------------------------------------");

// Získejte nejvyšší známky všech studentů

var heigher = marks
    .GroupBy(x => x.LastName)
    .Select(x => new Mark1VM
    {
        LastName = x.Key,
        Value = (int)x.Max(x => x.Value)
    });

foreach (var x in heigher)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}
Console.WriteLine("----------------------------------------------------------");

// Seřaďte studenty podle jejich průměrných známek

var avarage_students = marks
    .GroupBy(x => x.LastName)
    .Select(x => new Mark1VM
    {
        LastName = x.Key,
        Value = (int)x.Average(x => x.Value)
    })
    .OrderBy(x => x.Value);

foreach (var x in avarage_students)
{
    Console.WriteLine(x.LastName + " " + x.Value);
}




