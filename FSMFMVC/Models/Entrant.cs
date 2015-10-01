using System.ComponentModel.DataAnnotations;

namespace FSMFMVC.Models
{
    public class Entrant
    {
        public int ID { get; set; }
        public string UserEmail { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        [Display(Name = "School Attending")]
        public string SchoolAttending { get; set; }

        [Display(Name = "Grade In School")]
        public int? GradeInSchool { get; set; }

        [Required]
        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Grade In Music")]
        public int? GradeInMusic { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Display(Name = "Class Number")]
        public int? ClassNumber { get; set; }

        [StringLength(100)]
        [Display(Name = "Instrument(s)")]
        public string Instruments { get; set; }

        [StringLength(140)]
        [Display(Name = "Title of Selection")]
        [DataType(DataType.MultilineText)]
        public string Selection { get; set; }

        [Range(0, 240)]
        [DataType(DataType.Duration)]
        public int? PerformanceTime { get; set; }

        [Display(Name = "Number Of Paricipants")]
        public int? NumberOfParicipants { get; set; }

        [StringLength(200)]
        [Display(Name = "List names of other participants")]
        [DataType(DataType.MultilineText)]
        public string ParicipantsNames { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(100)]
        [Display(Name = "Name of Accompanist")]
        public string NameofAccompanist { get; set; }

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string MusicSupervisorsFirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string MusicSupervisorsLastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string MusicSupervisorsPhone { get; set; }

        [Display(Name = "Alternate Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string MusicSupervisorsAlternatePhone { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string MusicSupervisorsEmail { get; set; }

        public bool Volunteer { get; set; }

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string VolunteerFirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string VolunteerLastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string VolunteerPhone { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(200)]
        [Display(Name = "Special Requests")]
        [DataType(DataType.MultilineText)]
        public string SpecialRequests { get; set; }
    }
}