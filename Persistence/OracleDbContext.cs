using EcoWave_GS.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoWave_GS.Persistence;

public class OracleDbContext : DbContext
{
    public DbSet <MdContatos> Contatos { get; set; }

    public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
    {
        
    }
    
}