using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository
{
    public interface IExamRepository : IDataRepository<Exam>
    {
        Task<ExamResponse> GetExamWithQuestionsAndAnswer(int id);
        //Task<>
    }
}
