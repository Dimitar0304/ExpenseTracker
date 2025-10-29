using ExpenseTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.DtoModels
{
    public class ExpenseDto : IFinanceEntity
    {
        public Guid Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        public string Type { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(3000)]
        public string Summary { get; set; }
        public DateTime Date { get; set; }
    }
}
