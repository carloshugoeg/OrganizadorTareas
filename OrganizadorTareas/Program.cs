using OrganizadorTareas;

List <Tarea> Tareas = new List<Tarea>();
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("╔══════════════════════════╗");
    Console.WriteLine("║ ORGANIZADOR DE TAREAS CH ║");
    Console.WriteLine("╠══════════════════════════╣");
    Console.WriteLine("║ SELECCIONE UNA OPCION:   ║");
    Console.WriteLine("║       1. Agregar tarea   ║");
    Console.WriteLine("║       2. Ver tareas      ║");
    Console.WriteLine("║       3. Completar tarea ║");
    Console.WriteLine("╚══════════════════════════╝");
    Console.ResetColor();
    Console.Write("\nIngrese un numero para continuar a dicho menu: ");
    string option = Console.ReadLine().Trim();
    switch (option)
    {
        case "1":
            AgregarTarea();
    }
} while(true);

void AgregarTarea()
{
    string nombre = null, descripcion = null;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("╔══════════════════════════╗");
    Console.WriteLine("║       AGREGAR TAREA      ║");
    Console.WriteLine("╚══════════════════════════╝\n");
    (int left, int top) = Console.GetCursorPosition();
    do
    {
        Console.SetCursorPosition(left, top);
        Console.Write("Ingrese Nombre tarea: ");
        nombre = Console.ReadLine().ToUpper().TrimEnd();
    } while (nombre is null || nombre.Length == 0);
    (left,top) = Console.GetCursorPosition();
    do
    {
        Console.SetCursorPosition(left, top);
        Console.Write("Ingrese Descripcion: ");
        descripcion = Console.ReadLine().TrimEnd();
    } while (descripcion is null || descripcion.Length == 0);

}
