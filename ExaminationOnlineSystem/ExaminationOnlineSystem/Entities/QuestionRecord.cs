using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.Entities
{
    public class QuestionRecord
    {
        public int Id { get; set; }
        [Required]
        public bool A { get; set; }
        [Required]
        public bool B { get; set; }
        [Required]
        public bool C { get; set; }
        [Required]
        public bool D { get; set; }
        public int QuestionId { get; set; }
        public int StudentDoExemId { get; set; }
    }
}
