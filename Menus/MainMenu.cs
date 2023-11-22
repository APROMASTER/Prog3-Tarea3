class MainMenu
{
    public static bool salir = false;
    public static void DisplayMainMenu()
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
            Write.Lines();
            
            response = Console.ReadLine();
            Console.Clear();
            
            switch (response.ToLower())
            {
                case "1": break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "x": salir = true; break;
                default: break;
            }
        }
    }
}