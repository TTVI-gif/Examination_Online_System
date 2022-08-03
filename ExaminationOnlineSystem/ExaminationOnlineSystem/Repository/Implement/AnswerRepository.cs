using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class AnswerRepository : DataRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(IExamSystemDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Answer>> GetAnswerByQuestionId(int questionId)
        {
            var listAnswer = await DbSet.Where(x => x.QuestionId == questionId).ToListAsync();
            return listAnswer;
        }
    }
}
