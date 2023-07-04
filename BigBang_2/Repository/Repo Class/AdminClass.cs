using BigBang_2.Models;
using BigBang_2.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BigBang_2.Repository.Repo_Class
{
    public class AdminClass:IAdmin
    {
        private readonly HospitalContext _context;

        public AdminClass(HospitalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task<Admin> GetAdmin(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public async Task AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAdmin(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdmin(Admin admin)
        {
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> AdminExists(int id)
        {
            return await _context.Admins.AnyAsync(e => e.Admin_Id == id);
        }

        // Additional methods for handling doctors
        public async Task<IEnumerable<Doctor>> GetDoctorRequests()
        {
            return await _context.Doctors.Where(d => d.Status == "Pending").ToListAsync();
        }

        public async Task<Doctor> GetDoctor(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task UpdateDoctor(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Doctor>> GetDoctorsWithPendingStatus()
        {
            return await _context.Doctors.Where(d => d.Status == "Pending").ToListAsync();
        }
    }
}
