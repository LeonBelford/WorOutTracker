
using FitnessTracker.Components.Pages.FitnessTracker;
using Microsoft.EntityFrameworkCore;
namespace FitnessTracker.Components.Pages.FitnessTracker.FitnesDbContext;

public class PersonDbContext : DbContext
{

    public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
    {
    }
    public DbSet<WorkoutTracker> WorkoutTracker { get; set; }
    public DbSet<TrackedPerson> TrackedPerson { get; set; }



}

