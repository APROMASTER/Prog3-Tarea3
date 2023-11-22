class ChoreAddMenu : Menu
{
    public override void Display()
    {
        while (salir == false)
        {
            Write.Lines();
            Write.Title("Agregar Chore");
            Write.Lines();
            Write.Paragraph("Inserte 'x' para regresar");
            Write.LineJump();
            
            Console.Write("Nombra el nuevo chore: ");
            response = Console.ReadLine();
            Console.Clear();
            
            if (response.ToLower() == "x") salir = true;
            else
            {
                ChoresData.Instance.SaveChore(new Chore(response, false));
                Console.WriteLine($"El chore {response} ha sido creado exitosamente");
                Console.ReadKey();
                Console.Clear();
                salir = true;
            }
        }
    }
}