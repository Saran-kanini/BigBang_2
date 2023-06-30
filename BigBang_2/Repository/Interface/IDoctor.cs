using BigBang_2.Models;

namespace BigBang_2.Repository.Interface
{
    public interface IDoctor
    {
        Task<IEnumerable<Doctor>> GetDoctors();
        Task<Doctor> GetDoctor(int id);
        Task AddDoctor(Doctor doctor);
        Task UpdateDoctor(Doctor doctor);
        Task DeleteDoctor(Doctor doctor);
        Task<bool> DoctorExists(int id);

    }
}
