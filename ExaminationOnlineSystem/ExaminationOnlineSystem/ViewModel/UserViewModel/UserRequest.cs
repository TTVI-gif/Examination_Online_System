using ExaminationOnlineSystem.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.UserViewModel
{
    public class UserRequest
    {
        public UserRequest(User user)
        {
            Id = user.Id;
            LastName = user.LastName;
            FirstName = user.FirstName;
            BirthDay = user.BirthDay;
            PhoneNumber = user.PhoneNumber;
            Email = user.Email;
        }
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
