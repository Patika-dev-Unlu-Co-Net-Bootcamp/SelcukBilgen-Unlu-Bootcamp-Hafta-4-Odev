using System;

namespace CounselingCenter.Api.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string Description { get; set; }
        public string Recommendation { get; set; }
        public AppUser User { get; set; }
    }
}