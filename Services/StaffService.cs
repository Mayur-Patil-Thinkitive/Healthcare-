using Healthcare_.Models;
using System.Collections.Generic;
using System.Linq;

namespace Healthcare_.Services
{
    public class StaffService : IStaffService
    {
        private readonly List<Staff> _staffList = new List<Staff>();
        private int _nextId = 1;

        public Staff AddStaff(Staff staff)
        {
            staff.Id = _nextId++;
            _staffList.Add(staff);
            return staff;
        }

        public Staff EditStaff(int id, Staff updatedStaff)
        {
            var staff = _staffList.FirstOrDefault(s => s.Id == id);
            if (staff == null) return null;

            staff.FirstName = updatedStaff.FirstName;
            staff.LastName = updatedStaff.LastName;
            staff.EmailId = updatedStaff.EmailId;
            staff.ContactNumber = updatedStaff.ContactNumber;
            staff.Status = updatedStaff.Status;
            staff.Role = updatedStaff.Role;
            return staff;
        }

        public Staff GetStaffById(int id)
        {
            return _staffList.FirstOrDefault(s => s.Id == id);
        }
    }
}
