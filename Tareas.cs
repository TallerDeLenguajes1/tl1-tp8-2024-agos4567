using System;
using System.Collections.Generic;

namespace ClasesGeneral
{
    public class Tarea
    {
        private int idTarea;
        private int duracion;
        private string? descripcion;

        public int IdTarea { get => idTarea; set => idTarea = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }

        public Tarea(int idTarea, int duracion, string descripcion)
        {
            this.IdTarea = idTarea;
            this.Duracion = duracion;
            this.Descripcion = descripcion;
        }

        public void MostrarTarea()
        {
            Console.WriteLine($"ID de la tarea: {IdTarea}");
            Console.WriteLine($"Descripción de la tarea: {Descripcion}");
            Console.WriteLine($"Duración de la tarea: {Duracion}");
            Console.WriteLine("----------------------");
        }
    }

    public class Funciones
    {
        public void MostrarTareas(List<Tarea> listaDeTareas)
        {
            if (listaDeTareas.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                foreach (Tarea tarea in listaDeTareas)
                {
                    tarea.MostrarTarea();
                }
            }
        }

        public List<Tarea> CargarTareas(int cantPend)
        {
            List<Tarea> tareas = new List<Tarea>();
            Random random = new Random();

            for (int i = 0; i < cantPend; i++)
            {
                Console.WriteLine($"Ingrese la descripción de la tarea {i + 1}:");
                string? descripcion = Console.ReadLine();
                int duracion = random.Next(10, 101); // Duración aleatoria entre 10 y 100

                // Crea una nueva tarea con los parámetros especificados y la añade a la lista de tareas
                Tarea tarea = new Tarea(i + 1, duracion, descripcion);
                tareas.Add(tarea);
            }

            return tareas;
        }

        public Tarea? BuscarTareaId(int idTarea, List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
        {
            foreach (Tarea tarea in tareasPendientes)
            {
                if (idTarea == tarea.IdTarea)
                {
                    return tarea;
                }
            }

            foreach (Tarea tarea in tareasRealizadas)
            {
                if (idTarea == tarea.IdTarea)
                {
                    return tarea;
                }
            }

            Console.WriteLine("ID no encontrado en ninguna lista.");
            return null;
        }

        public Tarea? BuscarTareaClave(string? clave, List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
        {
            foreach (Tarea tarea in tareasPendientes)
            {
                if (tarea.Descripcion == clave)
                {
                    return tarea;
                }
            }

            foreach (Tarea tarea in tareasRealizadas)
            {
                if (tarea.Descripcion == clave)
                {
                    return tarea;
                }
            }

            Console.WriteLine("Descripción no encontrada en ninguna lista.");
            return null;
        }

        public void MoverTarea(int idTarea, List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
        {
            Tarea? tareaEncontrada = BuscarTareaId(idTarea, tareasPendientes, tareasRealizadas);

            if (tareaEncontrada != null)
            {
                tareasRealizadas.Add(tareaEncontrada);
                tareasPendientes.Remove(tareaEncontrada);
                Console.WriteLine($"Tarea con ID {idTarea} movida a lista de tareas realizadas.");
            }
            else
            {
                Console.WriteLine($"No se encontró ninguna tarea con ID {idTarea} en las listas.");
            }
        }
    }
}
