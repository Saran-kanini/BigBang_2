using BigBang_2.Models;

namespace BigBang_2.Repository.Interface
{
    public interface IAdmin
    {
        Task<IEnumerable<Admin>> GetAdmins();
        Task<Admin> GetAdmin(int id);
        Task AddAdmin(Admin admin);
        Task UpdateAdmin(Admin admin);
        Task DeleteAdmin(Admin admin);
        Task<bool> AdminExists(int id);

        // Additional methods for handling doctors
        Task<IEnumerable<Doctor>> GetDoctorRequests();
        Task<Doctor> GetDoctor(int id);
        Task UpdateDoctor(Doctor doctor);
        Task<IEnumerable<Doctor>> GetDoctorsWithPendingStatus();

    }
}
