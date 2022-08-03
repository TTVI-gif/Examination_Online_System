using AutoMapper;
using ExaminationOnlineSystem.EF;
using ExaminationOnlineSystem.Entities;
using ExaminationOnlineSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Repository.Implement
{
    public class StudentDoExamRepository : DataRepository<StudentDoExam>, IStudentDoExamRepository
    {
        public StudentDoExamRepository(IExamSystemDbContext context) : base(context)
        {

        }

        public async Task<List<StudentDoExam>> GetDoExamByStudentId(int studentId)
        {
            var listDoExam = await DbSet.Where(x => x.StudentId == studentId).ToListAsync();
            return listDoExam;
        }



    }
}
