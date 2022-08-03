using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Exeption;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.UOF;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service.Implement
{
    public class ExamService : IExamService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQuestionService _questionService;
        private readonly IStudentDoExamService _studentDoExamService;
        public ExamService(IMapper mapper, IUnitOfWork unitOfWork,
            IQuestionService questionService, IStudentDoExamService studentDoExamService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _questionService = questionService;
            _studentDoExamService = studentDoExamService;
        }

        public async Task<AVGScoreResponse> CountAVGScoreByStudentId(int studentId)
        {
            decimal count = 0;
            decimal aVGScore = 0;
            var listDoExamByStudentId = await _studentDoExamService.GetDoExamByStudentId(studentId);
            if (listDoExamByStudentId == null)
                throw new AppException($"Answer with QuestionId = {studentId} is null");
            for (int i = 0; i < listDoExamByStudentId.Count; i++)
            {
                count = count + listDoExamByStudentId[i].score;
            }
            aVGScore = aVGScore + count / listDoExamByStudentId.Count;
            return new AVGScoreResponse
            {
                StudentId = studentId,
                AVGScore = aVGScore
            };
        }

        /// <summary>
        /// Tao bài thi
        /// </summary>
        /// <param name="examCreateRequest"></param>
        /// <returns></returns>
        public async Task<Exam> CreateAsync(ExamCreateRequest examCreateRequest)
        {
            if (examCreateRequest == null)
                throw new AppException("examCreateRequest is null");
            var exam = _mapper.Map<Exam>(examCreateRequest);
            await _unitOfWork.ExamRepository.AddAsync(exam);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Create exam is failt");
            return exam;
        }

        /// <summary>
        /// Xóa bài thi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int id)
        {
            var exam = await _unitOfWork.ExamRepository.GetByIdAsync(id);
            if (exam == null)
                throw new AppException($"exam with id = {id} is null");
            _unitOfWork.ExamRepository.Delete(exam);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                return false;
            return true;
        }

        public async Task<IEnumerable<ExamRequest>> GetAllAsync()
        {
            var exams = await _unitOfWork.ExamRepository.GetAllAsync(x => new ExamRequest(x));
            if (exams == null)
                throw new AppException($"exams is null");
            return exams;
        }

        public async Task<ExamWithManyQuestionRequest> GetByIdAsync(int id)
        {
            var exam = await _unitOfWork.ExamRepository.GetByIdAsync(id);
            if (exam == null)
                throw new AppException($"exam with id = {id} is null");
            //get list question by examid
            var listQuestion = await _questionService.GetQuestionsByExamId(id);
            return new ExamWithManyQuestionRequest()
            {
                Id = exam.Id,
                Content = exam.Content,
                Duration = exam.Duration,
                Score = exam.Score,
                QuestionAmount = exam.QuestionAmount,
                questionsByExamIdRequests = listQuestion
            };
        }

        public async Task<ExamCompletedResponse> GetExamCompletedByStudentId(int studentId)
        {
            List<ExamIsCompletedResponse> v = new List<ExamIsCompletedResponse>();
            var student = await _unitOfWork.UserRepository.GetByIdAsync(studentId);
            var listDoExam = await _unitOfWork.StudentDoExamRepository.GetDoExamByStudentId(studentId);
            for (int i = 0; i < listDoExam.Count; i++)
            {
                var examById = await _unitOfWork.ExamRepository.GetByIdAsync(listDoExam[i].ExamId);
                var a = _mapper.Map<ExamIsCompletedResponse>(examById);
                v.Add(a);
            }
            return new ExamCompletedResponse
            {
                studentId = studentId,
                lastName = student.LastName,
                FirstName = student.FirstName,
                exam = v
            };
        }



        public async Task<ExamResponse> GetExamWithQuestionAndAnswer(int id)
        {
            var exam = await _unitOfWork.ExamRepository.GetExamWithQuestionsAndAnswer(id);
            return exam;
        }

        public async Task<Exam> UpdateAsync(ExamUpdateRequest examUpdateRequest)
        {
            var exam = await _unitOfWork.ExamRepository.GetByIdAsync(examUpdateRequest.Id);
            if (exam == null)
                throw new AppException($"exam with id = {examUpdateRequest.Id} is null");
            exam.Content = examUpdateRequest.Content;
            exam.Duration = examUpdateRequest.Duration;
            exam.QuestionAmount = examUpdateRequest.QuestionAmount;
            _unitOfWork.ExamRepository.Update(exam);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Update exam with id = {examUpdateRequest.Id} is failt");
            return exam;
        }



    }
}
