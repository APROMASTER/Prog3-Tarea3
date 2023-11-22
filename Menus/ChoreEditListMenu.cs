class ChoreEditListMenu : Menu
{
    public override void Display()
    {
        string? response;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Editar Chore");
            Write.Lines();
            Write.LineJump();
            // -------------- Cambiar luego por la lista real con un For loop ------------ //
            Write.Enlisted('1', "Levantarme - Hecho");
            Write.Enlisted('2', "Cepillarme - No Hecho");
            Write.Enlisted('3', "Bañarme - No Hecho");
            Write.Enlisted('4', "Dormirme - No Hecho");
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
                // Agregar funcionalidad para editar chore
                Console.WriteLine($"El chore ha sido creado exitosamente");
                Console.Clear();
            }
        }
    }
}