using ExaminationOnlineSystem.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.AnswerViewModel
{
    public class AnswerRequest
    {
        public AnswerRequest(Answer answer)
        {
            Content = answer.Content;
            ImageUrl = answer.ImageUrl;
        }
        public string Content { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
