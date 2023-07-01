using BigBang_2.Models;
using BigBang_2.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BigBang_2.Repository.Repo_Class
{
    public class PatientClass:IPatient
    {
        private readonly HospitalContext _context;

        public PatientClass(HospitalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient> GetPatient(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);

            if (patient.Doctors != null)
            {
                var r = _context.Doctors.Find(patient.Doctors.Doctor_Id);
                patient.Doctors = r;
            }

            await _context.SaveChangesAsync();
        }


        public async Task UpdatePatient(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatient(Patient patient)
        {
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> PatientExists(int id)
        {
            return await _context.Patients.AnyAsync(e => e.Patient_Id == id);
        }
    }
}
