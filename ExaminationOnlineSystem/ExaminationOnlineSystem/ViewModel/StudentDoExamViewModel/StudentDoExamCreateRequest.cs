namespace ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel
{
    public class StudentDoExamCreateRequest
    {
        public int ExamId { get; set; }
        public int QuestionIds { get; set; }
        public string Survey { get; set; }
        public int StudentId { get; set; }
        public int Score { get; set; }
    }
}
