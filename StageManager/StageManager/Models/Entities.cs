using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StageManager.Models
{
    public class Entities : DbContext
    {
        public DbSet<Toewijzing> Toewijzingen { get; set; }

        public DbSet<Student> Studenten { get; set; }

        public DbSet<Docent> Docenten { get; set; }

        public DbSet<Bedrijf> Bedrijven { get; set; }

        public DbSet<Bedrijfsbegeleider> Bedrijfsbegeleiders { get; set; }
    }
}
