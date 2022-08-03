using ExaminationOnlineSystem.Filter;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.ViewModel.ExamViewModel;
using ExaminationOnlineSystem.ViewModel.QuestionViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Controllers
{
    [AuthorizeFilter(role: "Teacher")]
    [Route("[controller]/[Action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IQuestionService _questionService;

        public TeacherController(IExamService examService, IQuestionService questionService)
        {
            _examService = examService;
            _questionService = questionService;
        }

        /// <summary>
        /// Get Exam
        /// </summary>
        /// <returns>List Exam</returns>
        [HttpGet("Exam")]
        public async Task<IActionResult> Get()
        {
            var exams = await _examService.GetAllAsync();
            return Ok(exams);
        }

        /// <summary>
        /// Get Exam By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Exam with id </returns>

        [HttpGet("Exam/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var exam = await _examService.GetByIdAsync(id);
            return Ok(exam);
        }

        /// <summary>
        /// Create Exam
        /// </summary>
        /// <param name="examCreateRequest">Model to create exam</param>
        /// <returns></returns>
        [HttpPost("Exam")]
        public async Task<IActionResult> Create([FromForm] ExamCreateRequest examCreateRequest)
        {
            var examAdd = await _examService.CreateAsync(examCreateRequest);
            return Ok(examAdd);
        }

        /// <summary>
        /// Update exam
        /// </summary>
        /// <param name="examUpdateRequest">Model to update exam</param>
        /// <returns></returns>

        [HttpPut("Exam")]
        public async Task<IActionResult> Update([FromForm] ExamUpdateRequest examUpdateRequest)
        {
            var examUpdate = await _examService.UpdateAsync(examUpdateRequest);
            return Ok(examUpdate);
        }

        /// <summary>
        /// Delete exam by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Exam")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _examService.DeleteAsync(id);
            return Ok(result);
        }


        //API for question

        /// <summary>
        /// Get List Question
        /// </summary>
        /// <returns>List Question</returns>
        [HttpGet("Question")]
        public async Task<IActionResult> GetQuestion()
        {
            var ListQuestion = await _questionService.GetAllAsync();
            return Ok(ListQuestion);
        }

        /// <summary>
        /// Get question by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Question/{id}")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var question = await _questionService.GetByIdAsync(id);
            return Ok(question);
        }


        /// <summary>
        /// Create quetion with many answer
        /// </summary>
        /// <param name="questionCreateRequest"></param>
        /// <returns></returns>
        [HttpPost("Question")]
        public async Task<IActionResult> CreateQuestionWithMAnyAnswersAsync([FromBody] QuestionCreateRequest questionCreateRequest)
        {
            var QuestionWithAnsers = await _questionService.CreateAsync(questionCreateRequest);
            return Ok(QuestionWithAnsers);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteQuestionWithManyAnswers(int id)
        {
            var result = await _questionService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetAVGScore(int studentId)
        {
            var score = await _examService.CountAVGScoreByStudentId(studentId);
            return Ok(score);
        }

        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetExamCompletedByStudentId(int studentId)
        {
            var result = await _examService.GetExamCompletedByStudentId(studentId);
            return Ok(result);
        }
    }
}
