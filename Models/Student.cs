using System.Text.Json.Serialization;

namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ClassId { get; set; }
        [JsonIgnore]   
        public Class? Class { get; set; }
        public string? ImagePath { get; set; }

    }
}
