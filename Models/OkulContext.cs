using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudScaffolding.Models
{
    public class OkulContext: DbContext
    {
        public OkulContext(DbContextOptions<OkulContext> options): base(options)
        {
                    
        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }

       

    }
}
