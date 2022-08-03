using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class ExamWithManyQuestionRequest
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Duration { get; set; }
        public decimal? Score { get; set; }
        [Required]
        public int QuestionAmount { get; set; }
        public IEnumerable<QuestionsByExamIdRequest> questionsByExamIdRequests { get; set; }
    }
}
