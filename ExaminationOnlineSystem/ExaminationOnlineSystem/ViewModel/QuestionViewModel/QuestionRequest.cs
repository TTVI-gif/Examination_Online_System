using ExaminationOnlineSystem.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.QuestionViewModel
{
    public class QuestionRequest
    {
        public QuestionRequest(Question question)
        {
            Id = question.Id;
            Content = question.Content;
            ImageUrl = question.ImageUrl;
            ExamId = question.ExamId;
        }
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int ExamId { get; set; }
    }
}
