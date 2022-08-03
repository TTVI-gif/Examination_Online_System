using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.AnswerViewModel
{
    public class AnswerByQuestionIdRequest
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }
    }
}
