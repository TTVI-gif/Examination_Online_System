using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.QuestionViewModel
{
    public class QuestionsByExamIdRequest
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int ExamId { get; set; }
        public List<AnswerByQuestionIdRequest> answerByQuestionIdRequests { get; set; }
    }
}
