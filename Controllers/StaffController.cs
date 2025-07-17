using Healthcare_.Models;
using Healthcare_.Services;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost]
        public ActionResult<Staff> AddStaff([FromBody] Staff staff)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdStaff = _staffService.AddStaff(staff);
            return CreatedAtAction(nameof(GetStaffById), new { id = createdStaff.Id }, createdStaff);
        }

        [HttpPut("{id}")]
        public ActionResult<Staff> EditStaff(int id, [FromBody] Staff staff)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedStaff = _staffService.EditStaff(id, staff);
            if (updatedStaff == null)
                return NotFound();

            return Ok(updatedStaff);
        }

        [HttpGet("{id}")]
        public ActionResult<Staff> GetStaffById(int id)
        {
            var staff = _staffService.GetStaffById(id);
            if (staff == null)
                return NotFound();
            return Ok(staff);
        }
    }
}
