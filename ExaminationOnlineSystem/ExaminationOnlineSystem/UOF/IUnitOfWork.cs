using ExaminationOnlineSystem.Repository;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.UOF
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IExamRepository ExamRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IAnswerRepository AnswerRepository { get; }
        IStudentDoExamRepository StudentDoExamRepository { get; }
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
