using System;                    
using System.Collections.Generic; 
using TodoApp.Core;              

class Program
{
    static void Main()
    {
        var todos = new List<Todo>();  // Skapar en lista som lagrar alla Todo-objekt

        while (true)                   // Startar en kontinuerlig loop för menyinteraktion
        {
            Console.WriteLine("");     
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Lägg till uppgift");
            Console.WriteLine("2. Ta bort uppgift");
            Console.WriteLine("3. Visa uppgifter");
            Console.WriteLine("0. Avsluta");

            string choice = Console.ReadLine();  // Läser användarens menyval

            if (choice == "0") break;            // Avslutar programmet om användaren skriver 0

            switch (choice)                      // Hanterar de olika menyvalen
            {
                case "1":                        // Lägg till ny uppgift
                    Console.Write("Skriv ny uppgift: ");  // Frågar användaren om uppgiftens titel
                    string title = Console.ReadLine().Trim(); // Tar bort extra mellanslag
                    if (!string.IsNullOrEmpty(title))      // Ignorera tom sträng
                        todos.Add(new Todo { Title = title, IsDone = false }); // Skapar och lägger till Todo
                    break;

                case "2":                        // Tar bort uppgift
                    Console.Write("Skriv index att ta bort: "); // Frågar efter index
                    if (int.TryParse(Console.ReadLine(), out int index)) // Kontrollerar giltigt tal
                        if (index >= 0 && index < todos.Count)          // Kontrollera att index finns i listan
                            todos.RemoveAt(index);                     // Tar bort uppgiften
                    break;

                case "3":                        // Visar alla uppgifter
                    for (int i = 0; i < todos.Count; i++) // Loopar igenom listan
                    {
                        var todo = todos[i];             // Hämtar aktuell Todo
                        // Skriver ut index, titel och status (klar/ej klar)
                        Console.WriteLine(i + ": " + todo.Title + " - " + (todo.IsDone ? "Klar" : "Ej klar"));
                    }
                    break;

                default:                         // Om användaren skriver något annat än 0-3
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
        }
    }
}
