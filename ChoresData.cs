using Newtonsoft.Json;
class ChoresData
{
    public ChoresData() => Instance = this;
    public static ChoresData Instance = new ChoresData(); 
    static string saveFileName = "ChoreData.json";
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
        _chores.RemoveAt(index);
        _chores.Insert(index, choreToUpdate);
    }

    public void DeleteChore(int choreToDelete)
    {
        _chores.RemoveAt(choreToDelete);
    }

    public void SaveData()
    {
        try
        {
            if (_chores.Count == 0) throw new JsonException("No hay datos");
            string temp = JsonConvert.SerializeObject(_chores);
            System.IO.File.WriteAllText(saveFileName, temp);
            Console.WriteLine("Datos guardados correctamente.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos. ", ex);
        }
    }

    public void LoadData()
    {
        if (System.IO.File.Exists(saveFileName)) // -------------------------------- Cargar datos ------------------ //
        {
            try
            {
                string json = System.IO.File.ReadAllText(saveFileName);
                _chores = JsonConvert.DeserializeObject<List<Chore>>(json);
            }
            catch (Exception)
            {
                Console.WriteLine("Error al cargar los datos.");
            }
        }
    }
}