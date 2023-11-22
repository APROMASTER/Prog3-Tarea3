class ChoreDeleteMenu : Menu
{
    public override void Display()
    {
        int choreCount = ChoresData.Instance.GetChores().Count;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Eliminar Chore");
            Write.Lines();
            Write.LineJump();
            // -------------- Cambiar luego por la lista real con un For loop ------------ //
            for (int i = 0; i < choreCount; i++)
            {
                var enlistedChore = ChoresData.Instance.GetChore(i);
                string choreDone = enlistedChore.Done ? "Hecho" : "No hecho";
                Write.Enlisted(i + 1, $"{enlistedChore.Name} - {choreDone}");
            }
            Write.LineJump();
            Write.Enlisted('x', "Regresar al menu");
            Write.LineJump();
            Write.Lines();
            
            Console.Write("Eliga un chore para eliminar: ");
            response = Console.ReadLine();
            Console.Clear();
            
            if (response.ToLower() == "x") salir = true;
            else
            {
                int choreIndex;
                if (int.TryParse(response, out choreIndex))
                {
                    ChoresData.Instance.DeleteChore(choreIndex - 1);
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Seleccion invalida");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}