namespace TodoApp.Core
{
    // Representerar en enskild todo-uppgift
    public class Todo
    {
        public string Title { get; set; }   // Uppgiftens titel
        public bool IsDone { get; set; }    // Om uppgiften är klar
    }
}
