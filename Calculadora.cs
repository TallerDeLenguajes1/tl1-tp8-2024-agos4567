using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


  namespace EspacioCalculadora
  {

   public class Calculadora{ 

    private double dato;

    public double Resultado {get=>dato;}
    // declara y inicializa un campo privado llamado historial que es una lista de objetos de tipo Operacion. Esta lista almacenará todas las operaciones realizadas por la calculadora
      private List<Operacion> historial = new List<Operacion>();
      //Evita que el historial completo sea reemplazado o modificado directamente desde fuera de la clase.
      public List<Operacion> Historial { get => historial; }

            public Calculadora()
        {
            dato = 0; // Inicializar dato al crear la calculadora
        }
        public void suma (double sumando){
         historial.Add(new Operacion(dato, dato + sumando, TipoOperacion.Suma));
            dato += sumando;
           

         }
         
         public void resta (double sustraendo){
            historial.Add(new Operacion(dato, dato - sustraendo, TipoOperacion.Resta));
            dato -= sustraendo;
           
         }

          public void multiplicacion (double multiplicacion){
             historial.Add(new Operacion(dato, dato *multiplicacion, TipoOperacion.Multiplicacion));
            dato *=multiplicacion;
          }

          public void dividir (double divisor){


            string entrada;
            bool valido=false;
              
              if (divisor ==0)
              {
                do
                {
                    Console.WriteLine("el divisor debe ser distinto de cero, ingrese otro divisor");
                    entrada=Console.ReadLine();
                    valido=double.TryParse(entrada,out divisor);
                    
                } while (divisor ==0 || !valido);
              }
               historial.Add(new Operacion(dato, dato/divisor, TipoOperacion.Division));
               dato /=divisor;

          }


        //  public void Limpiar(double dato){
        //      historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
        //     dato = 0;
        //  }
         public void Limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }


         
    }
  }