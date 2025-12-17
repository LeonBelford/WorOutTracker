using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models;

public class TrackedPerson
{
    [Key]
    public int Id { get; set; }

    static int _nextPersonId;

    private string _name;
    private double _weight;
    public string PersonId;

    public string Name { get { return _name; } private set { _name = value; } }
    public double Weight { get { return _weight; } private set { _weight = value; } }
    static TrackedPerson()
    {
        Random random = new Random();
        _nextPersonId = Convert.ToInt32(random.Next(1000, 10000));
    }

    public TrackedPerson() { }
    public TrackedPerson(string name, double weigt)
    {
        Name = name; ;
        Weight = weigt;
        PersonId = _nextPersonId++.ToString("D10");
        Id = Convert.ToInt32(PersonId);
        Console.WriteLine($"Created new TrackedPerson {Name} - {this.PersonId} | {Weight}");
    }




}
