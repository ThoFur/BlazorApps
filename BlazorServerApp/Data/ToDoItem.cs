namespace BlazorServerApp.Data
{
    public class ToDoItem
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public Urgency Urgency { get; set; }
    }

    public enum Urgency
    {
        VeryUrgent,
        NotSoUrgent,
        ForLater
    }
}
