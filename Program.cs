﻿using System;
using System.Collections.Generic;
using ClasesGeneral;
using System.Collections.Generic;
using System.Text;

// See https://aka.ms/new-console-template for more information


// Console.WriteLine("Hello, World!");
  

  Random random = new Random();

  int cantPend= random.Next(1,4);
  Funciones funciones = new Funciones();
// bool condicion =false;
  List<Tarea> listaDeTareasPendientes = new List<Tarea>();


  List<Tarea> listaDeTareasR = new List<Tarea>();

  Tarea aux = new Tarea();


  int opcion =7;





     for (int i = 0; i < cantPend; i++)
     {
        Console.WriteLine(" //// Carga de Tareas: ////");
        Console.WriteLine("Ingrese la descripcion de la tarea: ");
        string? auxTarea = Console.ReadLine();
         Console.WriteLine("Ingrese la duracion ");
          int auxDuracion=Convert.ToInt32(Console.ReadLine());

         Tarea tarea= new Tarea();
              tarea.IDtarea = i+ 1;
              tarea.Descripcion=auxTarea;

          if (auxDuracion<10 || auxDuracion>100)
          {
             do
            {
      Console.WriteLine("Ingrese la duracion nuevamente (entre 10/100)");
       auxDuracion=Convert.ToInt32(Console.ReadLine());


              
            } while(auxDuracion<10 || auxDuracion>100);
          
          }

         
         
  if(auxDuracion>=10 || auxDuracion <=100)
         {
           
           tarea.Duracion= auxDuracion;
          }

         
              listaDeTareasPendientes.Add(tarea);
       }

        
       do
       {
        
            Console.WriteLine("(1)--MOSTRAR TAREAS PENDIENTES");
            Console.WriteLine("(2)--MOSTRAR TAREAS REALIZADAS");
             Console.WriteLine("(3)--MOVER--");
             Console.WriteLine("(4)--Buscar por palabra");
             Console.WriteLine("(5)--Buscar por id");
              Console.WriteLine("(0)--Cerrar");

               opcion=Convert.ToInt32(Console.ReadLine());

                
           switch (opcion)
           {
            case 1:
    
      Console.WriteLine("----Tareas pendientes-----");
      funciones.mostrarTareas(listaDeTareasPendientes);
       


            break;


          case 2:

            Console.WriteLine("----Tareas realizadas-----");
        funciones.mostrarTareas(listaDeTareasR);


            break;

         case 3:

    funciones.MoverTarea(listaDeTareasPendientes,listaDeTareasR);
         break;




            case 4:
                        Console.WriteLine("Ingrese la clave de la tarea a buscar:");
                        string clave = Console.ReadLine();
                        Tarea tareaClave = funciones.BuscarTareaClave(clave, listaDeTareasPendientes, listaDeTareasR);
                        if (tareaClave != null)
                        {
                            Console.WriteLine("---Tarea encontrada---");
                            Console.WriteLine($"ID de la tarea: {tareaClave.IDtarea}");
                            Console.WriteLine($"Descripción: {tareaClave.Descripcion}");
                            Console.WriteLine($"Duración: {tareaClave.Duracion}");
                        }
                        else
                        {
                            Console.WriteLine("Tarea no encontrada.");
                        }

        //     Console.WriteLine("Ingrese la clave de la tarea a buscar: ");
        //     string? clave=Console.ReadLine();

              
        // aux=funciones.BuscarTareaClave(clave, listaDeTareasPendientes, listaDeTareasR);
        //       Console.WriteLine("---Tarea encontrada---");
        //     Console.WriteLine("Id de la tarea:" +aux.IDtarea);
        //     Console.WriteLine("Descripcion: " + aux.Descripcion);
        // Console.WriteLine("Duracion: " + aux.Duracion);
             

            break;

            case 5:
             Console.WriteLine("Ingrese el ID de la tarea a buscar:");
                        int idbuscar = Convert.ToInt32(Console.ReadLine());
                        Tarea tareaId = funciones.BuscarTareaId(idbuscar, listaDeTareasPendientes, listaDeTareasR);
                        if (tareaId != null)
                        {
                            Console.WriteLine("---Tarea encontrada---");
                            Console.WriteLine($"ID de la tarea: {tareaId.IDtarea}");
                            Console.WriteLine($"Descripción: {tareaId.Descripcion}");
                            Console.WriteLine($"Duración: {tareaId.Duracion}");
                        }
                        else
                        {
                            Console.WriteLine("Tarea no encontrada.");
                        }

        //     Console.WriteLine("Ingrese el id de la tarea a buscar:");
        //       int idbuscar=Convert.ToInt32(Console.ReadLine());

        //         aux=funciones.BuscarTareaId(idbuscar, listaDeTareasPendientes, listaDeTareasR);
                  
              
        //     Console.WriteLine("Id de la tarea:" +aux.IDtarea);
         
        // Console.WriteLine("Descripcion: " + aux.Descripcion);
        // Console.WriteLine("Duracion: " + aux.Duracion);
            break;
            default:
            break;
           }




       } while (opcion !=0);


