class ChoresData
{
    List<Chore> _chores = new List<Chore>();

    public List<Chore> GetChores()
    {
        return _chores;
    }

    public Chore GetChore(int choreIndex)
    {
        return _chores[choreIndex];
    }

    public void SaveChore(Chore choreToSave)
    {
        _chores.Add(choreToSave);
    }

    public void UpdateChore(int index, Chore choreToUpdate)
    {
        _chores.Insert(index, choreToUpdate);
    }

    public void DeleteChore(int choreToDelete)
    {
        _chores.RemoveAt(choreToDelete);
    }
}