using EcoWave_GS.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoWave_GS.Data;

public class OracleDbContext : DbContext
{ 
    public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options)
    {
        
    }
    
    public DbSet <MdContatos> Contact { get; set; }
    
}