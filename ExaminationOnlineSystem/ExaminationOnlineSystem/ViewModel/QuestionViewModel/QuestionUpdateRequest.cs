using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.QuestionViewModel
{
    public class QuestionUpdateRequest
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int ExamId { get; set; }
    }
}
