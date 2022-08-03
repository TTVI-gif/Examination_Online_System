using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.AnswerViewModel
{
    public class AnswerResponse
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int QuestionId { get; set; }
    }
}
