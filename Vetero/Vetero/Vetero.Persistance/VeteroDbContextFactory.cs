using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Domain.Entities.WeatherData;

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
