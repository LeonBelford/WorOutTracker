using System.ComponentModel.DataAnnotations;

namespace FitnessTracker;

public class SetsRepsTracker
{
    [Key]
    public int Id {get; set;}
    private int _set;
    private int _reps;
    private DateTime _currentDay;

    public int Set { get { return _set; } private set { _set = value; } }
    public int Reps { get { return _reps; } private set { _reps = value; } }
    public DateTime CurrentDay { get { return _currentDay; } private set { _currentDay = value; } }

}
