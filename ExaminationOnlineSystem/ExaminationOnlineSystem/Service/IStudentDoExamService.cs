using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service
{
    public interface IStudentDoExamService
    {
        Task<StudentDoExam> CreateAsync(StudentDoExamCreateRequest studentDoExamCreateRequest);
        Task<List<StudentDoExamScoreResponse>> GetDoExamByStudentId(int studentId);
        Task<List<ExamIsCompletedResponse>> GetExamCompletedByStudentId(int studentId);
    }
}
