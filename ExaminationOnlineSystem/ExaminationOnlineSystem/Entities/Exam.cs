using ExaminationOnlineSystem.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class Exam : IHasId
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Duration { get; set; }
        public decimal Score { get; set; }
        [Required]
        public int QuestionAmount { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
