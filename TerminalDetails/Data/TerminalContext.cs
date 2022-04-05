namespace TerminalDetails.Data
{
    public class TerminalContext : DbContext
    {
        public TerminalContext(DbContextOptions<TerminalContext> options) :  base(options) { 
        }

        public DbSet<Terminal> Terminals { get; set; }
    }
}
