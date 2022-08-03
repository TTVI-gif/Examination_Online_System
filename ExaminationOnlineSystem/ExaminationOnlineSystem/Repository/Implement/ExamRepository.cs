using AutoMapper;
using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class ExamRepository : DataRepository<Exam>, IExamRepository
    {
        private readonly IExamSystemDbContext _context;
        private readonly IMapper _mapper;
        public ExamRepository(IExamSystemDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ExamResponse> GetExamWithQuestionsAndAnswer(int id)
        {
            var exam = await DbSet.Include(exam => exam.Questions)
                .ThenInclude(question => question.Answers).FirstOrDefaultAsync(x => x.Id == id);
            var ListExmaRepon = _mapper.Map<ExamResponse>(exam);
            return ListExmaRepon;
        }


    }


}


