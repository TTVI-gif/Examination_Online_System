using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.AnswerViewModel
{
    public class AnswerCreateRequest
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public bool IsRight { get; set; }
        public string ImageUrl { get; set; }
    }
}
