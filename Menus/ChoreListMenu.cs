class ChoreListMenu : Menu
{
    public override void Display()
    {
        string? response;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Chores List");
            Write.Lines();
            Write.LineJump();
            // -------------- Cambiar luego por la lista real con un For loop ------------ //
            Write.Enlisted('1', "Levantarme - Done");
            Write.Enlisted('2', "Cepillarme - Not Done");
            Write.Enlisted('3', "Bañarme - Not Done");
            Write.Enlisted('4', "Dormirme - Not Done");
            Write.LineJump();
            Write.Enlisted('x', "Regresar al menu");
            Write.LineJump();
            Write.Lines();
            
            Console.Write("Select chore to Do/Undo: ");
            response = Console.ReadLine();
            Console.Clear();
            
            if (response.ToLower() == "x") salir = true;
            
        }
    }
}