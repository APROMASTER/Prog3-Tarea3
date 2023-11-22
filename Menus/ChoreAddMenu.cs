class ChoreAddMenu : Menu
{
    public override void Display()
    {
        string? choreName;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Agregar Chore");
            Write.Lines();
            
            Console.Write("Nombra el nuevo chore: ");
            choreName = Console.ReadLine();
            Console.Clear();
            
            if (choreName.ToLower() == "x") salir = true;
            else
            {
                // Agregar funcionalidad para guardar chore
                Console.WriteLine($"El chore {choreName} ha sido creado exitosamente");
                Console.Clear();
            }
        }
    }
}