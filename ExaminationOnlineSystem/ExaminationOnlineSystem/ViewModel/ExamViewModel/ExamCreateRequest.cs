using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class ExamCreateRequest
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int QuestionAmount { get; set; }
        public int ExamId { get; set; }
    }
}
