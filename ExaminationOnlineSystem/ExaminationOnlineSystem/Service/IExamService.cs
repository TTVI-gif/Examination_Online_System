using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service
{
    public interface IExamService
    {
        Task<Exam> CreateAsync(ExamCreateRequest examCreateRequest);
        Task<IEnumerable<ExamRequest>> GetAllAsync();
        Task<Exam> UpdateAsync(ExamUpdateRequest examUpdateRequest);
        Task<bool> DeleteAsync(int id);
        Task<ExamWithManyQuestionRequest> GetByIdAsync(int id);
        Task<ExamResponse> GetExamWithQuestionAndAnswer(int id);
        Task<AVGScoreResponse> CountAVGScoreByStudentId(int studentId);
        Task<ExamCompletedResponse> GetExamCompletedByStudentId(int studentId);
    }
}
