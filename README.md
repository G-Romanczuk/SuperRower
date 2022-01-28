# SuperRower
Gabriela Romańczuk nr. 13258
Witam w projekcie zaliczeniowym z przedmiotu "Programowanie w środowisku ASP.NET" ! 
Aplikacja stworzona jest w środowisku ASP.NET 5.0 więc zaleca się otwarcie jej w programie Visual Studio 2019. 
Po otwarciu pliku SuperRower.sln proszę o wejście w plik Startup.cs oraz w 32 linijce dodanie connection stringa do bazy danych.
Następnie kliknąć Tools -> NuGet Package Manager -> Package Manager Console
W konsoli należy wpisać: 
update-database

Następnie kliknąć F5, aby odpalić aplikację
Strona zawiera Autoryzację użytkowników, bez konta możemy jedynie zobaczyć Typy i ceny rowerów
Aby sprawdzić wszystkie możliwości strony należy:
1. Wejść w Typy rowerów po wynajęcia -> Dodaj Rower -> Wypełnić formularz -> DODAJ
2. Preferowane jest dodanie co najmniej 3 przykładowych rekordów do formularza ze względu na walidację formularza transakcji!
3.Wejść w Ceny za Rowery -> Dodaj cenę -> wypełnić formularz cyfrą
4. Preferowane jest dodanie co najmniej 3 przykładowych rekordów do formularza ze względu na walidację formularza transakcji!
5. Wejść w Klienci -> nie jest możliwe wejście bez zalogowania! więc
6. Register - zarejestrować nasze kontro na stronie
7.Login - zalogować się na konto podanymi wcześniej danymi
8. Wejść w Klienci -> Dodaj Klienta -> Wypełnić formularz przykładowymi danymi
9. Wejść w transakcje -> Wynajmij Rower -> Wypełnić formularz: Ważne, aby w polach:
            Numer Klienta wpisać numer przykładowego klienta z Klienci
            Numer Ceny wpisać numer przykładowej ceny z Ceny za rowery
            Numer Roweru wpisać numer przykładowego roweru z typy rowerów
          
Do api dostajemy się wpisując .../api/API/    
            
           Gotowe! Dostępna jest pełna funkcjinalność strony

