using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class ExamUpdateRequest
    {
        [Required]
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int QuestionAmount { get; set; }
    }
}
