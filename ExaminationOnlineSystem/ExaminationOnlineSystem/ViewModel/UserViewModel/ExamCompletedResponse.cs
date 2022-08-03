using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using System.Collections.Generic;

namespace ExaminationOnlineSystem.ViewModel.UserViewModel
{
    public class ExamCompletedResponse
    {
        public int studentId { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public List<ExamIsCompletedResponse> exam { get; set; }
    }
}
