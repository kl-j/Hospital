using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Entities
{
    public class MedicalHistory
    {
        public int Id { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public int PulseRate { get; set; }
        public string? MedicalConditions { get; set; }
        public string? CurrentMedication { get; set; }
        public string? SummaryOfFindings { get; set; }
    }
}
