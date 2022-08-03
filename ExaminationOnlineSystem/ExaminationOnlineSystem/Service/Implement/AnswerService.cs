using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Exeption;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.UOF;
using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Service.Implement
{
    public class AnswerService : IAnsweService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AnswerService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// trả về danh sách câu trả lời đúng từ danh sách truyền đến
        /// </summary>
        /// <param name="listAnswerId"></param>
        /// <returns></returns>
        public async Task<List<int>> CheckListRightAnswer(List<int> listAnswerId)
        {
            List<Answer> listAnswer = new List<Answer>();
            List<int> ListIsRightAnswerId = new List<int>();
            if (listAnswerId == null)
            {
                throw new AppException("Answer is Wrong");
            }
            for (int i = 0; i < listAnswerId.Count; i++)
            {
                var answer = await _unitOfWork.AnswerRepository.GetByIdAsync(listAnswerId[i]);
                if (answer == null)
                    throw new AppException("Answer is null");
                listAnswer.Add(answer);
            }
            for (int i = 0; i < listAnswer.Count; i++)
            {
                if (listAnswer[i].IsRight)
                {
                    ListIsRightAnswerId.Add(listAnswer[i].Id);
                }
            }
            return ListIsRightAnswerId;
        }



        public async Task<Answer> CreateAsync(AnswerCreateRequest answerCreateRequest)
        {
            if (answerCreateRequest == null)
                throw new AppException("AnswerCreateRequest is null");
            var answer = _mapper.Map<Answer>(answerCreateRequest);
            await _unitOfWork.AnswerRepository.AddAsync(answer);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Create Anwer is failt");
            return answer;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var answer = await _unitOfWork.AnswerRepository.GetByIdAsync(id);
            if (answer == null)
                throw new AppException($"Answer with id = {id} is null");
            _unitOfWork.AnswerRepository.Delete(answer);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Delete Anwer is failt");
            return true;
        }

        public async Task<IEnumerable<AnswerRequest>> GetAllAsync()
        {
            var listAnswer = await _unitOfWork.AnswerRepository.GetAllAsync(x => new AnswerRequest(x));
            if (listAnswer == null)
                throw new AppException($"listAnswer is null");
            return listAnswer;
        }

        public async Task<AnswerRequest> GetByIdAsync(int id)
        {
            var answer = await _unitOfWork.AnswerRepository.GetByIdAsync(id);
            if (answer == null)
                throw new AppException($"Answer with id = {id} is null");
            return new AnswerRequest(answer);
        }

        /// <summary>
        /// Get answer by question id
        /// </summary>
        /// <param name="questionId"></param>
        /// <returns>List answer</returns>

        public async Task<IEnumerable<AnswerByQuestionIdRequest>> GetByQuestionId(int questionId)
        {
            var listAnswerByQuestionId = await _unitOfWork.AnswerRepository.GetAnswerByQuestionId(questionId);
            if (listAnswerByQuestionId == null)
                throw new AppException($"Answer with QuestionId = {questionId} is null");
            var listAnswer = _mapper.Map<IEnumerable<AnswerByQuestionIdRequest>>(listAnswerByQuestionId);
            return listAnswer;
        }

        public async Task<Answer> UpdateAsync(AnswerUpdateRequest answerUpdateRequest)
        {
            var answer = await _unitOfWork.AnswerRepository.GetByIdAsync(answerUpdateRequest.Id);
            if (answerUpdateRequest == null)
                throw new AppException("answerUpdateRequest is null");
            answer = _mapper.Map<Answer>(answerUpdateRequest);
            _unitOfWork.AnswerRepository.Update(answer);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result == 0)
                throw new AppException($"Update ansứer is failt");
            return answer;
        }
    }
}
