using ExaminationOnlineSystem.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class StudentDoExam : IHasId
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateDoExam { get; set; }
        [Required]
        public decimal Score { get; set; }
        [Required]
        public string Survey { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public User Student { get; set; }
    }
}
