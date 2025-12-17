using FitnessTracker.Database;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Services
{
    public class PersonService
    {
        private PersonDbContext dbContext;

        public PersonService(PersonDbContext dbContext)
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


