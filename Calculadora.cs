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


        public void suma (double sumando){
         historial.Add(new Operacion(dato, sumando, TipoOperacion.Suma));
            dato += sumando;
           

         }
         
         public void resta (double sustraendo){
            historial.Add(new Operacion(dato, sustraendo, TipoOperacion.Resta));
            dato -= sustraendo;
           
         }

          public void multiplicacion (double multiplicacion){
             historial.Add(new Operacion(dato, multiplicacion, TipoOperacion.Multiplicacion));
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
               historial.Add(new Operacion(dato, divisor, TipoOperacion.Division));
               dato /=divisor;

          }


         public void Limpiar(double dato){
            dato=0;
         }


         
    }
  }