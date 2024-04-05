using ExamenUnidadII.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenUnidadII.Database
{
    public class IMCDatabaseContext : DbContext
    {

        public IMCDatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<PatientEntity> Patient { get; set; }

    }
}
