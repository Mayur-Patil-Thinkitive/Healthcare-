using Healthcare_.Models;

namespace Healthcare_.Services
{
    public interface IStaffService
    {
        Staff AddStaff(Staff staff);
        Staff EditStaff(int id, Staff staff);
        Staff GetStaffById(int id);
    }
}
