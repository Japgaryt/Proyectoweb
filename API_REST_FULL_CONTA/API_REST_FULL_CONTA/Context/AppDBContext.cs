using API_REST_CONTA.Entity;
using API_REST_FULL_CONTA.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST_CONTA.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        // Tablas del contexto
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Parametrizaciones> Parametrizaciones { get; set; }
        public DbSet<Asientos_Contables> Asientos_Contables { get; set; }
    }
}
