using System.ComponentModel.DataAnnotations;

namespace CustomerManagementAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] 
        public string Name { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }
    }
}
