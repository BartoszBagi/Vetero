using Microsoft.EntityFrameworkCore;

namespace Vetero.Persistance
{
    public class VeteroDbContextFactory : DesignTimeDbContextFactoryBase<VeteroDbContext>
    {
        public VeteroDbContextFactory()
        {

        }
        protected override VeteroDbContext CreateNewInstance(DbContextOptions<VeteroDbContext> options)
        {
            return new VeteroDbContext(options);
        }
    }
}
