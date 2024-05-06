using System.ComponentModel.DataAnnotations;

namespace mvcproject.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
    }
}