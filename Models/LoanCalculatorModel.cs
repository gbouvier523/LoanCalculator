using System.ComponentModel.DataAnnotations;
namespace LoanCalculator.Models
{
    public class LoanCalculatorModel
    {
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter yearly salary.")]
        public double? YearlySalary { get; set; }
        [Required(ErrorMessage = "Please enter credit code.")]
        [Range(1, 3, ErrorMessage = "Credit code must be between 1 and 3.")]
        public int? CreditCode { get; set; }
        public double? CalculateLoanAmount()
        {
            double? loanAmount = YearlySalary * .10;
            if (CreditCode > 0)
            {
                if (CreditCode == 1)
                {
                    loanAmount += YearlySalary * .05;
                }
                else
                {
                    loanAmount += YearlySalary * .02;
                }
            }
            else
            {
                loanAmount = 0;
            }
            return loanAmount;
        }
    }
}
