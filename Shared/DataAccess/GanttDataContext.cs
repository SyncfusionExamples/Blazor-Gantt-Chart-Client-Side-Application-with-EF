using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;

namespace MyBlazorApp.Shared.DataAccess
{
    public class GanttDataContext : DbContext
    {
        public virtual DbSet<GanttDataDetails> GanttData { get; set; }

        public GanttDataContext(DbContextOptions<GanttDataContext> options)
            : base(options) { }
    }
}
