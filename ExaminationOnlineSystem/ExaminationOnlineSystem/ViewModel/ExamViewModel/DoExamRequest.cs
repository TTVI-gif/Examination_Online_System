using System.Collections.Generic;

namespace ExaminationOnlineSystem.ViewModel.ExamViewModel
{
    public class DoExamRequest
    {
        public int ExamId { get; set; }
        public List<int> AnswerId { get; set; }
    }
}
