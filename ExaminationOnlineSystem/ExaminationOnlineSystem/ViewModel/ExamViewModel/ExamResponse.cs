using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using System.Collections.Generic;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class ExamResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Duration { get; set; }
        public List<QuestionResponse> questions { get; set; }
    }
}
