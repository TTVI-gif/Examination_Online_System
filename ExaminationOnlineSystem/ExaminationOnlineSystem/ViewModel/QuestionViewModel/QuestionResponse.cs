using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using System.Collections.Generic;

namespace ExaminationOnlineSystem.ViewModel.QuestionViewModel
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int ExamId { get; set; }
        public List<AnswerResponse> Answers { get; set; }
    }
}
