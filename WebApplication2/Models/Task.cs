using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Value { get; set;}

        public Task(string text)
        {
            this.Value = text;
        }
        public Task(int id,string text)
        {
            this.Id = id;
            this.Value = text;
        }
        public Task()
        {
            
        }
    }
}
