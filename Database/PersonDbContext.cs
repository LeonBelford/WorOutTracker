namespace FitnessTracker.Database;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

public class PersonDbContext : DbContext
{

    public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
    {
    }
    public DbSet<WorkoutTracker> WorkoutTracker { get; set; }
    public DbSet<TrackedPerson> TrackedPerson { get; set; }


}

