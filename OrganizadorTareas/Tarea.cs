using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorTareas
{
    internal class Tarea
    {
        public Tarea(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Completada = false;
        }

        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private bool Completada { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine("--------TAREA---------");
            Console.WriteLine("\nNombre: " + Nombre);
            Console.WriteLine("\nDescripcion: " +  Descripcion);
            Console.Write("\nCompletada: ");
            if (Completada) Console.WriteLine("Si");
            else Console.WriteLine("No");
        }
        
        public void CompletarTarea(bool completada) => Completada = completada;

        public bool GetCompletada()
        {

        return Completada; }
    }
}
