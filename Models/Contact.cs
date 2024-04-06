using System.ComponentModel.DataAnnotations;

namespace ContactCRUD.Models
{
    public class Contact
    {
       
        [Required, Range(1, int.MaxValue, ErrorMessage = "The Id can't be smaller than 1.")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a contact First name")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Last name.")]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Please give the Email. Thanks! :)")]
        public string Email { get; set; } = string.Empty;
        [Phone]
        public string PhoneNumber { get; set; }

    }
}
