namespace TodoApi.Models
{
    public class Application
    {

        public int ApplicationID { get; set; }
        public required string Description { get; set; }
        public DateTime EntryDate { get; set; }
        public required DateTime Deadline { get; set; }
        public bool Solved { get; set; }
    }
}
