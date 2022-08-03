using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Exeption;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.UOF;
using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service.Implement
{
    public class StudentDoExamService : IStudentDoExamService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public StudentDoExamService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        public async Task<StudentDoExam> CreateAsync(StudentDoExamCreateRequest studentDoExamCreateRequest)
        {
            if (studentDoExamCreateRequest == null)
                throw new AppException("AnswerCreateRequest is null");
            var DoExam = new StudentDoExam
            {
                ExamId = studentDoExamCreateRequest.ExamId,
                Score = studentDoExamCreateRequest.Score,
                StudentId = studentDoExamCreateRequest.StudentId,
                DateDoExam = System.DateTime.Now,
                Survey = studentDoExamCreateRequest.Survey
            };
            await _unitOfWork.StudentDoExamRepository.AddAsync(DoExam);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Create StudentDoExam is failt");
            return DoExam;
        }

        public async Task<List<StudentDoExamScoreResponse>> GetDoExamByStudentId(int studentId)
        {
            var listDoExamByStudentId = await _unitOfWork.StudentDoExamRepository.GetDoExamByStudentId(studentId);
            if (listDoExamByStudentId == null)
                throw new AppException($"DoExam with QuestionId = {studentId} is null");
            var listDoExam = _mapper.Map<List<StudentDoExamScoreResponse>>(listDoExamByStudentId);
            return listDoExam;
        }

        public async Task<List<ExamIsCompletedResponse>> GetExamCompletedByStudentId(int studentId)
        {
            var listDoExamByStudentId = await _unitOfWork.StudentDoExamRepository.GetDoExamByStudentId(studentId);
            if (listDoExamByStudentId == null)
                throw new AppException($"DoExam with QuestionId = {studentId} is null");
            var listDoExam = _mapper.Map<List<ExamIsCompletedResponse>>(listDoExamByStudentId);
            return listDoExam;
        }
    }
}
