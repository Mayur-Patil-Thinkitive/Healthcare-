using System.ComponentModel.DataAnnotations;

namespace Healthcare_.Models
{
    public enum StaffStatus
    {
        Active,
        Inactive
    }

    public enum StaffRole
    {
        PracticeOwner,
        Director,
        FrontOfficeAdmin,
        RecordsCustodian
    }

    public class Staff
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        [Phone]
        public string ContactNumber { get; set; }

        [Required]
        public StaffStatus Status { get; set; }

        [Required]
        public StaffRole Role { get; set; }
    }
}
