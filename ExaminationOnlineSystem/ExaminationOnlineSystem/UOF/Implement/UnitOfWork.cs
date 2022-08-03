using AutoMapper;
using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Repository;
using ExaminationOnlineSystem.Repository.Implement;
using ExaminationOnlineSystem.UOF;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.UOF.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        private IExamSystemDbContext _context;
        private IUserRepository _userRepository;
        private IExamRepository _examRepository;
        private IQuestionRepository _questionRepository;
        private IAnswerRepository _answerRepository;
        private readonly IMapper _mapper;
        private IStudentDoExamRepository _studentDoExamRepository;
        public UnitOfWork(IExamSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public IExamRepository ExamRepository
        {
            get
            {
                if (_examRepository == null)
                {
                    _examRepository = new ExamRepository(_context, _mapper);
                }
                return _examRepository;
            }
        }

        public IQuestionRepository QuestionRepository
        {
            get
            {
                if (_questionRepository == null)
                {
                    _questionRepository = new QuestionRepository(_context);
                }
                return _questionRepository;
            }
        }

        public IAnswerRepository AnswerRepository
        {
            get
            {
                if (_answerRepository == null)
                {
                    _answerRepository = new AnswerRepository(_context);
                }
                return _answerRepository;
            }
        }

        public IStudentDoExamRepository StudentDoExamRepository
        {
            get
            {
                if (_studentDoExamRepository == null)
                {
                    _studentDoExamRepository = new StudentDoExamRepository(_context);
                }
                return _studentDoExamRepository;
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }


    }
}
