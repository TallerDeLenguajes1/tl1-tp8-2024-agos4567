﻿using EspacioCalculadora;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


            Calculadora cal1= new Calculadora();
     
          double num=0;
          // bool valido=false;
          bool continuar = true;

        

        
          int op=0;

              // TipoOperacion operacion;
   
       do
       { 
             Console.WriteLine("Ingresa la operacion a realizar:");
             Console.WriteLine("-1 suma");
             Console.WriteLine("-2 resta");
             Console.WriteLine("-3 multiplicacion");
             Console.WriteLine("-4 division");
             Console.WriteLine("-5 Limpiar");
             Console.WriteLine("-6 historial");
             Console.WriteLine("- 0 salir");


            string entrada= Console.ReadLine();

              int opcion;

              if (!int.TryParse(entrada, out opcion) || opcion < 0 || opcion > 6)
              {
                  Console.WriteLine("Opción no válida. Por favor, elige una opción del 0 al 6.");
                    continue;
              }
           
               if (opcion != 5 && opcion != 6)
               {
                Console.WriteLine("Ingrese un numero");
                entrada=Console.ReadLine();

                 if (!double.TryParse(entrada, out num))
                 {
                  Console.WriteLine("Numero invalido. Intenta de nuevo");
                  continue;
                 }


               }

                        switch (opcion) {
                
                    
                   case 1:
                   Console.WriteLine("El resultado de la suma es");
                   cal1.suma(num);
                   Console.WriteLine(cal1.Resultado);
                   break;


                    case 2:
                   Console.WriteLine("El resultado de la resta es");
                   cal1.resta(num);
                   Console.WriteLine(cal1.Resultado);
                   break;

                   case 3:
                  Console.WriteLine("El resultado de la multiplicacion es");
                   cal1.multiplicacion(num);
                   Console.WriteLine(cal1.Resultado);
                   break;

                 case 4:
                 Console.WriteLine("El resultado de la division es");
                   cal1.dividir(num);
                   Console.WriteLine(cal1.Resultado);
                 break;
                

                case 5:
               cal1.Limpiar();
               Console.WriteLine("Historial limpio");
                break;

                case 6:
               int val =1;
            
              foreach (Operacion opp in cal1.Historial)
        {
            Console.WriteLine($"\nOperación {val}");
            Console.WriteLine($"Dato de entrada: {opp.ResultadoAnterior}");
            Console.WriteLine($"Operación: {opp.OperacionRealizada}");
            Console.WriteLine($"Resultado: {opp.NuevoValor}");
            val++;
        }
           
                break;
           case 0:
            continuar = false;
            break;

                   default:
                     Console.WriteLine("Opción no válida. Por favor, elige una opción del 0 al 6.");
                   break;
                   
                 }
      


        Console.WriteLine("Presiona cualquier letra para continuar...");
        Console.ReadKey();
        Console.Clear();





        
       } while (continuar);
 