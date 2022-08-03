using ExaminationOnlineSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class Answer : IHasId
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public bool IsRight { get; set; }
        public string ImageUrl { get; set; }
        public int QuestionId { get; set; }
        //public Question Question { get; set; }
    }
}
