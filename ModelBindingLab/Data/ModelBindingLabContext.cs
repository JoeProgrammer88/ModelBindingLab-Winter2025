using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelBindingLab.Models;

namespace ModelBindingLab.Data
{
    public class ModelBindingLabContext : DbContext
    {
        public ModelBindingLabContext (DbContextOptions<ModelBindingLabContext> options)
            : base(options)
        {
        }

        public DbSet<ModelBindingLab.Models.Product> Product { get; set; } = default!;
    }
}
