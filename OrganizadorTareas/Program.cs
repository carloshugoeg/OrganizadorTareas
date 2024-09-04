﻿using OrganizadorTareas;

List <Tarea> Tareas = new List<Tarea>();
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("╔══════════════════════════╗");
    Console.WriteLine("║ ORGANIZADOR DE TAREAS CH ║");
    Console.WriteLine("╠══════════════════════════╣");
    Console.WriteLine("║ SELECCIONE UNA OPCION:   ║");
    Console.WriteLine("║       1. Agregar tarea   ║");
    Console.WriteLine("║       2. Ver tareas      ║");
    Console.WriteLine("║       3. Completar tarea ║");
    Console.WriteLine("║       4. Salir           ║");
    Console.WriteLine("╚══════════════════════════╝");
    Console.ResetColor();
    Console.Write("\nIngrese un numero para continuar a dicho menu: ");
    string option = Console.ReadLine().Trim();
    switch (option)
    {
        case "1":
            AgregarTarea();
            break;
        case "2":
            VerTareas();
            break;
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
        Console.Write("\nIngrese Descripcion: ");
        descripcion = Console.ReadLine().TrimEnd();
    } while (descripcion is null || descripcion.Length == 0);
    Tareas.Add(new Tarea(nombre, descripcion));
    MensajeConfirmacion();

}

void VerTareas()
{
    Console.Clear();
    if(Tareas.Count == 0)
    {
        MensajeNoTareas();
        return;
    }
    (List<Tarea> Incompletas, List<Tarea> Completas) = SortTareas(Tareas);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Presione ENTER para salir en cualquier momento");
    Console.WriteLine(" ╔═══════════════════════════════════════════════╗");
    Console.WriteLine(" ║                 COMPLETADAS...                ║");
    Console.WriteLine(" ╚═══════════════════════════════════════════════╝\n");
    foreach (Tarea Tarea in Completas) Tarea.MostrarInfo();
    Console.WriteLine(" \n╔═══════════════════════════════════════════════╗");
    Console.WriteLine(" ║                 INCOMPLETAS...                ║");
    Console.WriteLine(" ╚═══════════════════════════════════════════════╝\n");
    foreach (Tarea Tarea in Incompletas) Tarea.MostrarInfo();
    Console.ReadLine();
}

void MensajeNoTareas()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" ╔═══════════════════════════════════════════════╗");
    Console.WriteLine(" ║          NO HAY TAREAS EN EL SISTEMA          ║");
    Console.WriteLine(" ╚═══════════════════════════════════════════════╝\n");
    Console.WriteLine("Presione ENTER para salir");
    Console.ReadLine();
}
void MensajeConfirmacion()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(" ╔═══════════════════════════════════════════════╗");
    Console.WriteLine(" ║              Ingresando Tarea...              ║");
    Console.WriteLine(" ╚═══════════════════════════════════════════════╝");

    //Esta función hace qué se pueda agregar un tiempo de espera
    //Y simular de mejor manera el hecho de validar una tarjeta
    System.Threading.Thread.Sleep(1000); // Espera de 1 
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" \n ╔═══════════════════════════════════════════════╗");
    Console.WriteLine(" ║         ¡TAREA AGREGADA EXITOSAMENTE!         ║");
    Console.WriteLine(" ╠═══════════════════════════════════════════════╣");
    Console.WriteLine(" ║   La tarea se ha agregado con exito           ║");
    Console.WriteLine(" ║   Para completarla puede entrar al menu '3'   ║");
    Console.WriteLine(" ║   Presione Enter para continuar               ║");
    Console.WriteLine(" ╚═══════════════════════════════════════════════╝");
    Console.ReadLine();
}

(List<Tarea> Incompletas,  List<Tarea> Completas) SortTareas(List<Tarea> Tareas)
{
    List<Tarea> Completadas = new List<Tarea>();
    List<Tarea> Incompletas = new List<Tarea>();
    foreach (Tarea Tarea in Tareas)
    {
        if (Tarea.GetCompletada())
        {
            Completadas.Add(Tarea);
        }
        else Incompletas.Add(Tarea);
    }
    return (Incompletas, Completadas);
}