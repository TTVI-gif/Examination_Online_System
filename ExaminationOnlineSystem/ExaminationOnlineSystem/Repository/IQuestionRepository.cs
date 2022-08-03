using ExaminationOnlineSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository
{
    public interface IQuestionRepository : IDataRepository<Question>
    {
        Task<IEnumerable<Question>> GetQuestionsByExamIdAsync(int examId);
    }
}
