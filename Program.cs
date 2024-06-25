﻿using System;
using ClasesGeneral;
using System.Collections.Generic;


            Random random = new Random();
            Funciones funciones = new Funciones();
            List<Tarea> tareasPendientes = new List<Tarea>();
            List<Tarea> tareasRealizadas = new List<Tarea>();
            int opcion;

            do
            {
                Console.WriteLine("\nElija una opción:");
                Console.WriteLine("1. Cargar Tarea en Pendientes");
                Console.WriteLine("2. Mostrar Tareas Pendientes");
                Console.WriteLine("3. Mostrar Tareas Realizadas");
                Console.WriteLine("4. Mover Tarea de Pendientes a Realizadas");
                Console.WriteLine("5. Buscar Tarea por Descripción");
                Console.WriteLine("6. Buscar Tarea por ID");
                Console.WriteLine("0. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n//// Cargar Tarea en Pendientes ////");
                        Console.WriteLine("Ingrese la cantidad de tareas a cargar:");
                        int cantPend = Convert.ToInt32(Console.ReadLine());
                        List<Tarea> nuevasTareas = funciones.CargarTareas(cantPend);
                        tareasPendientes.AddRange(nuevasTareas);
                        break;

                    case 2:
                        Console.WriteLine("--- Mostrar tareas pendientes ---");
                        funciones.MostrarTareas(tareasPendientes);
                        break;

                    case 3:
                        Console.WriteLine("--- Mostrar tareas realizadas ---");
                        funciones.MostrarTareas(tareasRealizadas);
                        break;

                    case 4:
                        Console.WriteLine("\n//// Mover Tarea de Pendientes a Realizadas ////");
                        Console.WriteLine("Ingrese el ID de la tarea que desea mover:");
                        int idTareaMover = Convert.ToInt32(Console.ReadLine());
                        Tarea tareaAMover = funciones.BuscarTareaId(idTareaMover, tareasPendientes, tareasRealizadas);
                        if (tareaAMover != null)
                        {
                            funciones.MoverTarea(idTareaMover, tareasPendientes, tareasRealizadas);
                        }
                        else
                        {
                            Console.WriteLine("Tarea no encontrada en la lista de pendientes.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n//// Buscar Tarea por Descripción ////");
                        Console.WriteLine("Ingrese la descripción de la tarea:");
                        string descripcionBusqueda = Console.ReadLine();
                        Tarea tareaEncontradaDescripcion = funciones.BuscarTareaClave(descripcionBusqueda, tareasPendientes, tareasRealizadas);
                        if (tareaEncontradaDescripcion != null)
                        {
                            tareaEncontradaDescripcion.MostrarTarea();
                        }
                        else
                        {
                            Console.WriteLine("Tarea no encontrada.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("\n//// Buscar Tarea por ID ////");
                        Console.WriteLine("Ingrese el ID de la tarea:");
                        int idBusqueda = Convert.ToInt32(Console.ReadLine());
                        Tarea tareaEncontrada = funciones.BuscarTareaId(idBusqueda, tareasPendientes, tareasRealizadas);
                        if (tareaEncontrada != null)
                        {
                            tareaEncontrada.MostrarTarea();
                        }
                        else
                        {
                            Console.WriteLine("Tarea no encontrada.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
