class ChoreEditMenu : Menu
{
    public int choreIndex = -1;
    
    public override void Display()
    {
        var choreToUpdate = ChoresData.Instance.GetChore(choreIndex);
        string? breforeName = choreToUpdate.Name;
        string choreDone = choreToUpdate.Done ? "Si" : "No";
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Editar Chore");
            Write.Lines();
            Write.LineJump();
            Write.Paragraph($"Nombre: {breforeName}");
            Write.Paragraph($"Hecho: {choreDone}");
            Write.LineJump();
            Write.Lines();
            Console.Write("Asigna el nuevo nombre del chore: ");
            response = Console.ReadLine();
            Console.Clear();
            
            if (response.ToLower() == "x") salir = true;
            else
            {
                var choreUpdate = new Chore(response, choreToUpdate.Done);
                ChoresData.Instance.UpdateChore(choreIndex, choreUpdate);
                Console.WriteLine($"El chore {breforeName} ahora se llama -> {response}.");
                Console.ReadKey();
                Console.Clear();
                salir = true;
            }
        }
    }
}