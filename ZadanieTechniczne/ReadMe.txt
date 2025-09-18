//




Zakres zadania:

Dodawanie liczb do kolekcji
Endpoint: POST /numbers
Prześlij tablicę liczb całkowitych (np. w JSON: [1, 2, 3, 4, 5])
Dane dodajesz do kolekcji trzymanej w pamięci albo – jeśli wolisz – w plikowej bazie (np. SQLite)
Pobieranie liczb
Endpoint: GET /numbers
Powinien zwrócić aktualny stan kolekcji
Sortowanie liczb
Endpoint: GET /numbers/sorted?sort=asc|desc
Pozwala posortować kolekcję rosnąco lub malejąco – kierunek określasz parametrem
Wyszukiwanie liczby
Endpoint: GET /numbers/search?value=42
Sprawdzasz, czy wskazana liczba istnieje w kolekcji
Zwróć np. { "value": 42, "found": true } albo { "value": 99, "found": false }
Statystyki
Endpoint: GET /numbers/stats
Powinien zwracać średnią i medianę aktualnego zbioru
(Opcjonalnie) Przetwarzanie równoległe
Endpoint: POST /numbers/process/parallel
Jeśli chcesz się, zaimplementuj wersję, która przetwarza dużą kolekcję równolegle
Możesz np. policzyć sumę i średnią w sposób wielowątkowy i zwrócić coś takiego:
{
  "count": 100000,
  "sum": 4999995000,
  "average": 49999.95
}"