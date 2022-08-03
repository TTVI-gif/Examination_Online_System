using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service
{
    public interface IAnsweService
    {
        Task<Answer> CreateAsync(AnswerCreateRequest answerCreateRequest);
        Task<IEnumerable<AnswerRequest>> GetAllAsync();
        Task<Answer> UpdateAsync(AnswerUpdateRequest questionUpdateRequest);
        Task<bool> DeleteAsync(int id);
        //Task<AnswerRequest> GetByIdAsync(int id);
        Task<IEnumerable<AnswerByQuestionIdRequest>> GetByQuestionId(int questionId);
        Task<List<int>> CheckListRightAnswer(List<int> listAnswerId);

    }
}
