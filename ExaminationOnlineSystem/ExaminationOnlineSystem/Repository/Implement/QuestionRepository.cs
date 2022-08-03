using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class QuestionRepository : DataRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IExamSystemDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Question>> GetQuestionsByExamIdAsync(int examId)
        {
            var listQuestion = await DbSet.Where(x => x.ExamId == examId).ToListAsync();
            return listQuestion;
        }
    }
}
