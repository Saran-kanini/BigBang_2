using Microsoft.EntityFrameworkCore;
using System.Data;
using BigBang_2.Models;

namespace BigBang_2.Models
{
    public class HospitalContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }

    }
}
