using FitnessTracker.Services;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Components;

namespace FitnessTracker.Components.Pages.FitnessTracker;

public partial class FitnessUi : ComponentBase
{
    #region Injects

    [Inject]
    private PersonService _PersonService{ get; set; }

    #endregion

    public string personName = "";
    public double weight = 0;
    public List<TrackedPerson> Person = new List<TrackedPerson>();
    TrackedPerson pOptions = new();
    protected override async Task OnInitializedAsync()
    {
        Person = await _PersonService.GetPersonAsync();
    }

    private async Task CreatePersonObj()
    {
        TrackedPerson trackedPerson = new TrackedPerson(personName, weight);
        personName = string.Empty;
        await AddNewProduct(trackedPerson);
        weight = 0;
        Person = await RefreshSitePerson();
    }

    public async Task RefreshProducts()
    {
        Person = await _PersonService.GetPersonAsync();
    }
    public async Task<List<TrackedPerson>> RefreshSitePerson()
    {
        await RefreshProducts();
        return Person;
    }

    public async Task AddNewProduct(TrackedPerson newPerson)
    {
        await _PersonService.AddPersonAsync(newPerson);
        await RefreshProducts();
    }


    private async Task SetPersonForUpdate(TrackedPerson person)
    {
        TrackedPerson UpdatePerson = new TrackedPerson();
        UpdatePerson = person;
        await UpdatePersonData(UpdatePerson);
    }
    private async Task UpdatePersonData(TrackedPerson UpdatePerson)
    {
        await _PersonService.UpdatePersonAsync(UpdatePerson);
        await RefreshProducts();
    }
    private async Task DeletePerson(TrackedPerson person)
    {
        await _PersonService.DeletePersonAsync(person);
        await RefreshProducts();
    }

}