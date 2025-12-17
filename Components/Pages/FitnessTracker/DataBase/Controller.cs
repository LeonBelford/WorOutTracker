using FitnessTracker;
using FitnessTracker.Components.Pages.FitnessTracker.FitnesDbContext;
using Microsoft.EntityFrameworkCore;



namespace FitnessTracker.Components.Pages.FitnessTracker.FitnessController{
public class PersonController
  {
    private PersonDbContext dbContext;
  
    public PersonController(PersonDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
  
    /// <summary>
    /// This method returns the list of trackedPerson
    /// </summary>
    /// <returns></returns>
    public async Task<List<TrackedPerson>> GetPersonAsync()
    {
        return await dbContext.TrackedPerson.ToListAsync();
    }
    /// <summary>
    /// This method add a new trackedPerson to the DbContext and saves it
    /// </summary>
    /// <param name="trackedPerson"></param>
    /// <returns></returns>
    public async Task<TrackedPerson> AddPersonAsync(TrackedPerson trackedPerson)
    {
        try
        {
            dbContext.TrackedPerson.Add(trackedPerson);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return trackedPerson;
    }
    /// <summary>
    /// This method update and existing trackedPerson and saves the changes
    /// </summary>
    /// <param name="trackedPerson"></param>
    /// <returns></returns>
    public async Task<TrackedPerson> UpdatePersonAsync(TrackedPerson trackedPerson)
    {
        try
        {
            var productExist = dbContext.TrackedPerson.FirstOrDefault(p => p.Id == trackedPerson.Id);
            if (productExist != null)
            {
                dbContext.Update(trackedPerson);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return trackedPerson;
    }
    /// <summary>
    /// This method removes and existing trackedPerson from the DbContext and saves it
    /// </summary>
    /// <param name="trackedPerson"></param>
    /// <returns></returns>
    public async Task DeletePersonAsync(TrackedPerson trackedPerson)
    {
        try
        {
            dbContext.TrackedPerson.Remove(trackedPerson);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
   
}
}

public class SetRepController
  {
    private PersonDbContext dbContext;
  
    public SetRepController(PersonDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
  
    /// <summary>
    /// This method returns the list of trackedSetRep
    /// </summary>
    /// <returns></returns>
    public async Task<List<WorkoutTracker>> GetSetRepAsync()
    {
        return await dbContext.WorkoutTracker.ToListAsync();
    }
    /// <summary>
    /// This method add a new trackedSetRep to the DbContext and saves it
    /// </summary>
    /// <param name="trackedSetRep"></param>
    /// <returns></returns>
    public async Task<WorkoutTracker> AddSetRepAsync(WorkoutTracker trackedSetRep)
    {
        try
        {
            dbContext.WorkoutTracker.Add(trackedSetRep);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return trackedSetRep;
    }
    /// <summary>
    /// This method update and existing trackedSetRep and saves the changes
    /// </summary>
    /// <param name="trackedSetRep"></param>
    /// <returns></returns>
    public async Task<WorkoutTracker> UpdateSetRepAsync(WorkoutTracker trackedSetRep)
    {
        try
        {
            var setRepExist = dbContext.WorkoutTracker.FirstOrDefault(p => p.Id == trackedSetRep.Id);
            if (setRepExist != null)
            {
                dbContext.Update(trackedSetRep);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return trackedSetRep;
    }
    /// <summary>
    /// This method removes and existing trackedSetRep from the DbContext and saves it
    /// </summary>
    /// <param name="trackedSetRep"></param>
    /// <returns></returns>
    public async Task DeleteSetRepAsync(WorkoutTracker trackedSetRep)
    {
        try
        {
            dbContext.WorkoutTracker.Remove(trackedSetRep);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
   
}
