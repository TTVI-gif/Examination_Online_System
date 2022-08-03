using AutoMapper;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.ViewModel.AnswerViewModel;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using ExaminationOnlineSystem.ViewModel.UserViewModel;

namespace ExaminationOnlineSystem.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterRequest, User>();
            CreateMap<ExamCreateRequest, Exam>().ReverseMap();
            CreateMap<QuestionUpdateRequest, Question>();
            CreateMap<AnswerUpdateRequest, Answer>();
            CreateMap<QuestionCreateRequest, Question>();
            CreateMap<AnswerCreateRequest, Answer>();
            CreateMap<Exam, ExamResponse>().ReverseMap();
            CreateMap<Question, QuestionResponse>().ReverseMap();
            CreateMap<Answer, AnswerResponse>().ReverseMap();
            CreateMap<Answer, AnswerByQuestionIdRequest>().ReverseMap();
            CreateMap<Question, QuestionsByExamIdRequest>().ReverseMap();
            CreateMap<StudentDoExam, StudentDoExamCreateRequest>().ReverseMap();
            CreateMap<StudentDoExam, StudentDoExamScoreResponse>().ReverseMap();
            CreateMap<StudentDoExam, ExamIsCompletedResponse>().ReverseMap();
            CreateMap<Exam, ExamIsCompletedResponse>().ReverseMap();

        }
    }
}
