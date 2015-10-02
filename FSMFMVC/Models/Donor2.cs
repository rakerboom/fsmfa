using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FSMFMVC.Models
{
    public class Donor2
    {
        public int ID { get; set; }

        [Required]
        public int donor_id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string link { get; set; }
    }
}