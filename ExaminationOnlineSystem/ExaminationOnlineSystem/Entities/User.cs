using ExaminationOnlineSystem.Common;
using ExaminationOnlineSystem.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class User : IHasId
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public int? scoreId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public ICollection<StudentDoExam> StudentDoExams { get; set; }
    }
}
