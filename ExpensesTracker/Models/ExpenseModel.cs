using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesTracker.Models
{
    public class ExpenseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ET_Id { get; set; }
        [Required]
        public string ET_Expense_Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateOnly ET_Date { get; set; }
        [Required]
        public double ET_Amount { get; set; }
        [Required]
        public char ET_RefundYN { get; set; }
        public string? ET_Comments { get; set; }
    }
}
