# Reservations
Angular+WebAPI+Tests

1. SOLID w WebAPI
   
   Zasady SOLID zostały wprowadzone przez Roberta C. Martina i odnoszą się do podstaw projektowania oprogramowania:
   
   S - Single Responsibility Principle(Pojedyńcza odowiedzialność) -Komponent powinien sie skupiaać na jednej rzeczy i robic ją dobrze, nie zajmować się rzeczami które wychodza po za jego zakres.
   
   O - Open/Closed Principle(Zasada Otwartego/Zamkniętego) -Klasy i moduły powinny być otwarte na rozszerzenia, ale zamknięte dla modyfikacji. Nowe funkcjonalności powinny być dodawane przez rozszerzenie, a nie zmienianie istniejącego kodu.
   
   L - Liskov Substitution Principle(Zasada Podstawienia Liskov) -Obiekt danej klasy powinien być zastępowalny obiektem dowolnej z jej klas podrzędnych bez wprowadzania błędów w programie.
   
   I - Interface Segregation Principle(Zasada Segregacji Interfejsów) -Interfejsy powinny być małe i wyspecjalizowane klient nie był zmuszany do implementacji nieurzywanych metod.
   
   D - Dependency Inversion Principle(Zasada Odwrócenia Zależności) -Moduły wysokopoziomowe nie powinny zależeć od modułów niskopoziomowych. Obydwa powinny zależeć od abstrakcji. Ponadto, abstrakcje nie powinny zależeć od szczegółów. Szczegóły powinny zależeć od abstrakcji.
   
3. Testy Jednostkowe
   Do tworzenia testów jednostkowych mamy 2 podejscia/szkoły:
   a) Szkoła Detroit (inaczej amerykańska, Classicist, state based testing, Black-box testing), popularyzowana przez Uncle Bob’a, Kent Beck’a. - szkoła klasyczna - bez mokowania -przekazujemy wszystkie rzeczyiste komponenty - jednostką jest zetaw zalerznych klas.
   b) Szkoła Londyńska (inaczej Mockist, Interaction testing, white-box testing), popularyzowana przez Steve Freeman’a, czy Nat Pryce’a. - jednostką jest klasa.

   Bede używał podejscia szkoły Londyńskiej.
   
   Do czytelniejszości testów wykożystam nugeta: Shouldly - fluent asertion
4. Aplikacja Web Angular + Material
