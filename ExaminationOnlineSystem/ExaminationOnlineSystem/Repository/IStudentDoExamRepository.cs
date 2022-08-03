using ExaminationOnlineSystem.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository
{
    public interface IStudentDoExamRepository : IDataRepository<StudentDoExam>
    {
        Task<List<StudentDoExam>> GetDoExamByStudentId(int studentId);
    }
}
