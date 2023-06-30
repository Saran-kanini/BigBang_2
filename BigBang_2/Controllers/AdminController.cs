using BigBang_2.Models;
using BigBang_2.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigBang_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdmin _adminRepository;

        public AdminController(IAdmin adminRepository)
        {
            _adminRepository = adminRepository;
        }

        // GET: api/Admins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            var admins = await _adminRepository.GetAdmins();
            return Ok(admins);
        }

        // GET: api/Admins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _adminRepository.GetAdmin(id);

            if (admin == null)
            {
                return NotFound();
            }

            return Ok(admin);
        }

        // PUT: api/Admins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, Admin admin)
        {
            if (id != admin.Admin_Id)
            {
                return BadRequest();
            }

            await _adminRepository.UpdateAdmin(admin);

            return NoContent();
        }

        // POST: api/Admins
        [HttpPost]
        public async Task<ActionResult<Admin>> PostAdmin(Admin admin)
        {
            await _adminRepository.AddAdmin(admin);

            return CreatedAtAction("GetAdmin", new { id = admin.Admin_Id }, admin);
        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await _adminRepository.GetAdmin(id);
            if (admin == null)
            {
                return NotFound();
            }

            await _adminRepository.DeleteAdmin(admin);

            return NoContent();
        }
    }
}
