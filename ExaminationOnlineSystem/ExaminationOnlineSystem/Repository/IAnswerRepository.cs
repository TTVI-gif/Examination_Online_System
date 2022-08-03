using ExaminationOnlineSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository
{
    public interface IAnswerRepository : IDataRepository<Answer>
    {
        Task<IEnumerable<Answer>> GetAnswerByQuestionId(int questionId);
    }
}
