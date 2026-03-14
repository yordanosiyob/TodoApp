using TodoApp.Core;

namespace TodoApp.Tests;

public class UnitTest1
{
    [Fact]
    public void KanLäggaTillTodo()
    {
        // Arrange - Skapa en tom lista och en ny Todo
        var todos = new List<Todo>();
        
        // Act - Lägger till en Todo i listan
        todos.Add(new Todo { Title = "Handla mat", IsDone = false });

        // Assert - Kontrollerar att listan har ett objekt med rätt titel och status
        Assert.Single(todos);
        Assert.Equal("Handla mat", todos[0].Title);
        Assert.False(todos[0].IsDone);
    }

    [Fact]
    public void KanTaBortTodo()
    {
        // Arrange - Skapa en lista med en Todo
        var todos = new List<Todo>();
        todos.Add(new Todo { Title = "Handla mat", IsDone = false });

        // Act - Tar bort Todo på index 0
        todos.RemoveAt(0);

        // Assert - Kontrollera att listan är tom efter borttagning
        Assert.Empty(todos);
    }

    [Fact]
    public void TomTitelLäggsTillEj()
    {
        // Arrange - Skapa en tom lista och en titel med endast mellanslag
        var todos = new List<Todo>();
        string title = "   ";

        // Act - Försöker lägga till Todo med tom titel (ska ignoreras)
        if (!string.IsNullOrWhiteSpace(title))
            todos.Add(new Todo { Title = title, IsDone = false });

        // Assert - Kontrollera att listan fortfarande är tom
        Assert.Empty(todos);
    }
}