using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FSMFMVC.Models
{
    public class Executive
    {
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(10000), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string ImagePath { get; set; }
    }

    public class ExecutiveDBContext : DbContext
    {
        public DbSet<Executive> Executive { get; set; }
    }
}