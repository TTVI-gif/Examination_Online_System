using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service
{
    public interface IQuestionService
    {
        Task<Question> CreateAsync(QuestionCreateRequest questionCreateRequest);
        Task<IEnumerable<QuestionRequest>> GetAllAsync();
        Task<Question> UpdateAsync(QuestionUpdateRequest questionUpdateRequest);
        Task<bool> DeleteAsync(int id);
        Task<QuestionWithAnswersRequest> GetByIdAsync(int id);
        Task<IEnumerable<QuestionsByExamIdRequest>> GetQuestionsByExamId(int examId);
    }
}
