using System.Text.Json.Serialization;

namespace smirnovas.Models
{

    [JsonSerializable(typeof(TaskItem))]
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Например: "New", "In Progress", "Completed"
    }
}