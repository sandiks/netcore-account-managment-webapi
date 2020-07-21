using System.ComponentModel.DataAnnotations;

namespace AccountManagmentSystem.Models
{
    public class Account
    {
        public int Id { get; set; }

        public int UserId { get; set; }  
        public string UserName { get; set; }  
        public User User { get; set; }      
    }
}
