using System;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.UserViewModel
{
    public class UserUpdateRequest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public int Role { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
    }
}
