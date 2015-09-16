using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FSMFMVC.Models
{
    public class Biography
    {
        public int ID { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(2000), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }
    }

    public class StaticDataDBContext : DbContext
    {
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Executive> Executive { get; set; }
        public DbSet<Donor> Donor { get; set; }
        public DbSet<Entrant> Entrants { get; set; }
    }
}