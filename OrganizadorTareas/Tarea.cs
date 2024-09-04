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
            Console.WriteLine();
        }
        
        public void CompletarTarea() => Completada = true;

        public bool GetCompletada()
        {

        return Completada; }

        public string GetName()
        {
            return Nombre;
        }
    }
}
