using System.ComponentModel.DataAnnotations;

namespace AccountManagmentSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        
        [Required, RegularExpression("^(.+)@(.+)$")]
        [EmailUserUnique]
        public string Email { get; set; }

        [Range(0, 3000)]
        public int MonthlySalary { get; set; }

        [Range(0, 3000)]
        public int MonthlyExpenses { get; set; }
    }
}
