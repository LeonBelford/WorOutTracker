using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models;

public class WorkoutTracker
{
    [Key]
    public int Id { get; set;}
    private string _name = $"Person{WorkoutId++}";
    private int _normalSets;
    private int _normalReps;

    private DateTime _startDay = DateTime.Now;
    private List<SetsRepsTracker> _setsRepsTrackers;
    static int WorkoutId;

    public string Name { get { return _name; } private set { _name = value; } }
    public int NormalSets { get { return _normalSets; }  set { _normalSets = value; } }
    public int NormalReps { get { return _normalReps; }  set { _normalReps = value; } }
    public DateTime StartDay { get { return _startDay; } private set { _startDay = value; } }
    public List<SetsRepsTracker> setsRepsTrackers { get { return _setsRepsTrackers;} }

    static WorkoutTracker()
    {
        Random random = new Random();
        WorkoutId = random.Next(1000, 6000);
    }

    public WorkoutTracker(string name, int normalSets, int normalReps)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            //initial create
            Id = WorkoutId++;
            Name = name;
            NormalSets = normalSets;
            NormalReps = normalReps;
        }
        
    }

    public void AddCurrentSet(WorkoutTracker trackedWporkout, int set, int reps)
    {
        


    }





}
