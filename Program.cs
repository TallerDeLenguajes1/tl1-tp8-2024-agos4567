﻿using EspacioCalculadora;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


            Calculadora cal1= new Calculadora();
     
          double num;
          bool valido=false;

          string entrada;

          int opcion;
          int op=0;

              

        do
        {
            op=1;
            
                 do
                 {
                     Console.WriteLine("Ingrese el primer numero: ");
                entrada=Console.ReadLine();

                valido=double.TryParse(entrada, out num);


                Console.WriteLine("Ingresa la operaciona  realizar \n-1suma\n 2-resta\n 3-multiplicacion\n 4-division\n 5 limpiar\n \n 6 historial\n");
                entrada=Console.ReadLine();
                valido=int.TryParse(entrada,out opcion);

                 switch (opcion)
                 {
                    
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
               cal1.Limpiar(num);
               Console.WriteLine(cal1.Resultado);
                break;

                case 6:
               int val =1;
            
                foreach (Operacion opp in cal1.Historial )
                {
                  Console.WriteLine($"\nOperacion {val}");
                        Console.WriteLine($"\nDato de entrada: {opp.Resultado}");
                        Console.WriteLine($"\nOperacion: {opp.Operation}");
                        Console.WriteLine($"\nResultado: {opp.NuevoValor}");
                       val++;
                }
           
                break;

                   default:
                   break;
                   
                 }


                     if(!valido){
                            Console.WriteLine("el numero ingresado no es valido");
                        }


                 } while (!valido);


                      

            Console.WriteLine("Desea realizar otra operacion (1.SI/ 0.NO)");
            op=Convert.ToInt32(Console.ReadLine());
        } while (op !=0);

