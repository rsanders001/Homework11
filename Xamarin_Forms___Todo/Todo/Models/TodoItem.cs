using SQLite;

namespace Todo
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Joke { get; set; }
       
    }
}

