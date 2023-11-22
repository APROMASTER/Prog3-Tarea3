class ChoreEditMenu : Menu
{
    public int choreIndex = -1;
    
    public override void Display()
    {
        string? choreName;
        
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Editar Chore");
            Write.Lines();
            Write.LineJump();
            Write.Paragraph("Nombre del chore");
            Write.Paragraph("Hecho");
            Write.LineJump();
            Write.Lines();
            Console.Write("Asigna el nuevo nombre del chore: ");
            choreName = Console.ReadLine();
            Console.Clear();
            
            if (choreName.ToLower() == "x") salir = true;
            else
            {
                // Agregar funcionalidad para editar chore
                Console.WriteLine($"El chore ha sido editado exitosamente");
                Console.Clear();
            }
        }
    }
}