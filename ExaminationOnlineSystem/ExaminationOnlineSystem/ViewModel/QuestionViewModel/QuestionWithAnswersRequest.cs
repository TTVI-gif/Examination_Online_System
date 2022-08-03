using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.QuestionViewModel
{
    public class QuestionWithAnswersRequest
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int ExamId { get; set; }
        public IEnumerable<AnswerByQuestionIdRequest> answerRequest { get; set; }
    }
}
