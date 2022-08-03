using System;

namespace ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel
{
    public class ExamIsCompletedResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateDoExam { get; set; }
        public decimal Score { get; set; }
        public string Survey { get; set; }
    }
}
