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
    }
}
