using _28._09._2026;

Console.WriteLine("Hello, World!");

osoba osoba = new osoba(); //tworzymy nowy obiekt klasy osoba, wywołując konstruktor bezparametrowy
osoba.imie = "Jan"; //przypisujemy wartość do pola imie obiektu osoba 
//publiczne więc można zmieniać wartość pola
Console.WriteLine(osoba.imie);
osoba osoba2 = new osoba("Brunch", 30);
Console.WriteLine("Imię osoba2");
Console.WriteLine(osoba2.imie);
Console.WriteLine(osoba2);