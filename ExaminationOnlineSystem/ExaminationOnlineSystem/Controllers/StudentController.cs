using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.ViewModel.StudentDoExamViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IExamService _examService;
        private readonly IAnsweService _answeService;
        private readonly IStudentDoExamService _studentDoExamService;
        public StudentController(IExamService examService, IAnsweService answeService, IStudentDoExamService studentDoExamService)
        {
            _examService = examService;
            _answeService = answeService;
            _studentDoExamService = studentDoExamService;
        }
        [HttpGet]
        public async Task<IActionResult> GetExam(int id)
        {
            var exam = await _examService.GetExamWithQuestionAndAnswer(id);
            return Ok(exam);
        }

        [HttpPost]
        public async Task<IActionResult> CheckAnswer([FromForm] List<int> listAnswerId)
        {
            var result = await _answeService.CheckListRightAnswer(listAnswerId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> StudentDoExam(StudentDoExamCreateRequest studentDoExamCreateRequest)
        {
            var doExam = await _studentDoExamService.CreateAsync(studentDoExamCreateRequest);
            return Ok(doExam);
        }
    }
}
