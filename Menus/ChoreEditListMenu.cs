class ChoreEditListMenu : Menu
{
    public override void Display()
    {
        int choreCount = ChoresData.Instance.GetChores().Count;
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Editar Chore");
            Write.Lines();
            Write.LineJump();
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
            
            Console.Write("Eliga un chore para editar: ");
            response = Console.ReadLine();
            Console.Clear();
            
            if (response.ToLower() == "x") salir = true;
            else
            {
                int choreIndex;
                if (int.TryParse(response, out choreIndex))
                {
                    var choreEditMenu = new ChoreEditMenu();
                    choreEditMenu.choreIndex = choreIndex - 1;
                    choreEditMenu.Display();
                    
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