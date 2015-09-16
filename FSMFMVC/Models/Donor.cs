using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FSMFMVC.Models
{
    public class Donor
    {
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(2000), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}