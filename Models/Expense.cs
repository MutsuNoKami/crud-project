using System.ComponentModel.DataAnnotations;

namespace crud_project.Models
{
    public class Expense
    {
        public int id {get; set;}
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Amount cannot be below 0")]
        public string Description{get;set;}= null!;
        [Required]
        public double amount{get;set;}
        [Required]
        public string category{get;set;} = null!;
        public DateTime date{get;set;} = DateTime.Now;
    }
}