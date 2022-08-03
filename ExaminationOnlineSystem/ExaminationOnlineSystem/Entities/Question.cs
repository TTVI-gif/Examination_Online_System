using ExaminationOnlineSystem.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class Question : IHasId
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int ExamId { get; set; }
        public ICollection<Answer> Answers { get; set; }
        //public Exam Exam { get; set; }
    }
}
