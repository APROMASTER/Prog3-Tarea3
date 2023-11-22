public class Chore
{
    public string Name { get; private set; }
    public bool Done { get; private set; }
    public Chore(string name, bool done)
    {
        Name = name; 
        Done = done;
    }
    public void ToggleDone() => Done = !Done;
}