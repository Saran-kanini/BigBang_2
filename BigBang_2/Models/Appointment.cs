using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBang_2.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_Id { get; set; }
        public DateTime? Appointment_Date { get; set; }
        public string? Description { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public string PatientPhoneNumber { get; set; } = string.Empty;
        public string PatientEmail { get; set; } = string.Empty;

        // Navigation properties
        public int Patient_Id { get; set; }
        public Patient? Patient { get; set; }

        public int Doctor_Id { get; set; }
        public Doctor? Doctor { get; set; }

    }
}
