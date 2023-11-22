class MainMenu : Menu
{
    public override void Display()
    {
        string? response;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Chores");
            Write.Lines();
            Write.LineJump();
            Write.Enlisted('1', "Ver/realizar chores");
            Write.LineJump();
            Write.Enlisted('2', "Crear chore");
            Write.Enlisted('3', "Editar chore");
            Write.Enlisted('4', "Eliminar chore");
            Write.LineJump();
            Write.Enlisted('x', "Salir");
            Write.LineJump();
            Write.Lines();
            
            Console.Write("Eliga una opcion: ");
            response = Console.ReadLine();
            Console.Clear();
            
            switch (response.ToLower())
            {
                case "1": new ChoreListMenu().Display(); break;
                case "2": new ChoreAddMenu().Display(); break;
                case "3": new ChoreEditMenu().Display(); break;
                case "4": new ChoreDeleteMenu().Display(); break;
                case "x": salir = true; break;
                default: break;
            }
        }
    }
}