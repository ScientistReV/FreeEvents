using FreeEvent.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeEvent.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {  
        }
        public DbSet<Evento> Eventos { get; set; }


    }
}