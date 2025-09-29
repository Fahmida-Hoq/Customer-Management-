namespace CustomerManagementAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }           // Primary Key
        public string Name { get; set; }      // Customer Name
        public string Email { get; set; }     // Customer Email
        public string Phone { get; set; }     // Customer Phone
        public string Address { get; set; }   // Customer Address
    }
}
