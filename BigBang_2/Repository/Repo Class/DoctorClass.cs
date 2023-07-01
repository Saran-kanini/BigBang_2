using BigBang_2.Models;
using BigBang_2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BigBang_2.Repository.Repo_Class
{
    public class DoctorClass:IDoctor
    {
        private readonly HospitalContext _context;

        public DoctorClass(HospitalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Doctor>> GetDoctors()
        {
            return await _context.Doctors.Include(x => x.Patients).ToListAsync();
        }

        public async Task<Doctor> GetDoctor(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctor(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctor(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DoctorExists(int id)
        {
            return await _context.Doctors.AnyAsync(e => e.Doctor_Id == id);
        }
    }
}
