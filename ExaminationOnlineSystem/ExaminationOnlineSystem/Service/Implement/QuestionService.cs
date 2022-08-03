using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Exeption;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.UOF;
using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service.Implement
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAnsweService _answeService;
        public QuestionService(IMapper mapper, IUnitOfWork unitOfWork, IAnsweService answeService)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _answeService = answeService;
        }



        public async Task<Question> CreateAsync(QuestionCreateRequest questionCreateRequest)
        {
            if (questionCreateRequest == null)
                throw new AppException("QuestionCreateRequest is null");
            var question = _mapper.Map<Question>(questionCreateRequest);
            await _unitOfWork.QuestionRepository.AddAsync(question);
            await _unitOfWork.SaveChangesAsync();
            //add many answer wwith question
            foreach (var item in questionCreateRequest.answerCreateRequest)
            {
                var answer = _mapper.Map<Answer>(item);
                answer.QuestionId = question.Id;
                await _unitOfWork.AnswerRepository.AddAsync(answer);
            }

            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Create question is failt");
            return question;

        }


        public async Task<bool> DeleteAsync(int id)
        {
            var question = await _unitOfWork.QuestionRepository.GetByIdAsync(id);
            if (question == null)
                throw new AppException($"Delete is failt because Question with id = {id} is null");
            _unitOfWork.QuestionRepository.Delete(question);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Delete question is failt");
            return true;
        }

        public async Task<IEnumerable<QuestionRequest>> GetAllAsync()
        {
            var ListQuestions = await _unitOfWork.QuestionRepository.GetAllAsync(x => new QuestionRequest(x));
            if (ListQuestions == null)
                throw new AppException($"ListExams is null");
            return ListQuestions;
        }

        public async Task<QuestionWithAnswersRequest> GetByIdAsync(int id)
        {
            var question = await _unitOfWork.QuestionRepository.GetByIdAsync(id);
            if (question == null)
                throw new AppException($"Question with id = {id} is null");
            //Get List answer by question id
            var answer = await _answeService.GetByQuestionId(question.Id);
            return new QuestionWithAnswersRequest()
            {
                Id = question.Id,
                Content = question.Content,
                ImageUrl = question.ImageUrl,
                ExamId = question.ExamId,
                answerRequest = answer
            };
        }

        /// <summary>
        ///Get list question by examid 
        /// </summary>
        /// <param name="examId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<QuestionsByExamIdRequest>> GetQuestionsByExamId(int examId)
        {
            var listQuestion = await _unitOfWork.QuestionRepository.GetQuestionsByExamIdAsync(examId);
            if (listQuestion == null)
                throw new AppException($"listQuestion is null");
            var listQuestionMapper = _mapper.Map<IEnumerable<QuestionsByExamIdRequest>>(listQuestion);
            return listQuestionMapper;
        }

        public async Task<Question> UpdateAsync(QuestionUpdateRequest questionUpdateRequest)
        {
            var question = await _unitOfWork.QuestionRepository.GetByIdAsync(questionUpdateRequest.Id);
            if (question == null)
                throw new AppException($"Question with id = {questionUpdateRequest.Id} is null");
            question = _mapper.Map<Question>(questionUpdateRequest);
            _unitOfWork.QuestionRepository.Update(question);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Update question is failt");
            return question;
        }
    }
}
