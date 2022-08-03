using ExaminationOnlineSystem.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class ExamRequest
    {
        public ExamRequest(Exam exam)
        {
            Id = exam.Id;
            Content = exam.Content;
            Duration = exam.Duration;
            Score = exam.Score;
        }
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Duration { get; set; }
        public decimal? Score { get; set; }
        [Required]
        public int QuestionAmount { get; set; }
    }
}
