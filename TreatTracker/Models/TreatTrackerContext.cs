using Microsoft.EntityFrameworkCore;

namespace TreatTracker.Models
{
    public class TreatTrackerContext : DbContext
    {   
        public TreatTrackerContext(DbContextOptions options)
        
            : base(options) { }
    }
}