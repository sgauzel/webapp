using System.ComponentModel.DataAnnotations;

namespace demo_web_app.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
