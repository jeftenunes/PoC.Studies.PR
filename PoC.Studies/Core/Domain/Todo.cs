namespace PoC.Studies.Core.Domain
{
    public class Todo
    {
        public int? Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public Todo(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public Todo(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}