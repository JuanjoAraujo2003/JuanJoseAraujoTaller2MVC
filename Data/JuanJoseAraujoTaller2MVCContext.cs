using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanJoseAraujoTaller2MVC.Models;

namespace JuanJoseAraujoTaller2MVC.Data
{
    public class JuanJoseAraujoTaller2MVCContext : DbContext
    {
        public JuanJoseAraujoTaller2MVCContext (DbContextOptions<JuanJoseAraujoTaller2MVCContext> options)
            : base(options)
        {
        }

        public DbSet<JuanJoseAraujoTaller2MVC.Models.Burger> Burger { get; set; } = default!;
        public DbSet<JuanJoseAraujoTaller2MVC.Models.Promo> Promo { get; set; }
    }
}
