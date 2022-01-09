// See https://aka.ms/new-console-template for more information
using LINQDemo2022.Model;

// Alice Andělová P1
// Bořivoj Bohatý P1
// Ctirad Cudný P2
// Daniela Drozdová P2

// ALG, PRG, MAT, CJL

// https://docs.microsoft.com/cs-cz/dotnet/csharp/programming-guide/concepts/linq/
// https://www.tutorialsteacher.com/linq
// https://www.geeksforgeeks.org/linq-method-syntax/?ref=lbp

List<Mark> Marks = new List<Mark> { 
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
// Seřaďte záznamy podle data
// Seřaďte záznamy podle třídy sestupně
// Získejte jen známky studentky Alice
// Získejte jen známky z P1, nezískávejte ale jiné informace kromě příjmení a známky
// Získejte jen známky z P1, nezískávejte ale jiné informace kromě příjmení a známky
// Získejte jen známky z P1 seřazené podle příjmení studenta
// Získejte průměr všech známek studentky Alice
// Získejte známky z jednotlivých předmětů studentky Alice
// Získejte průměrné známky všech studentů
// Získejte nejvyšší známky všech studentů
// Seřaďte studenty podle jejich průměrných známek
