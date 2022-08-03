using System.ComponentModel.DataAnnotations;

namespace ExaminationOnlineSystem.ViewModel.Score
{
    public class ScoreCreateRequest
    {
        [Required]
        public decimal AGVScores { get; set; }
        [Required]
        public int StudentId { get; set; }
    }
}
