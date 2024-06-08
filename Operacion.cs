

 public class Operacion
    { 
//       public class Operacion{
  private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;


      public Operacion(double resultadoAnterior,double nuevoValor,TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.operacion = operacion;
            this.nuevoValor=nuevoValor;
        }
      public double Resultado { get => resultadoAnterior;}          private double dato;

      public double NuevoValor {get => nuevoValor;}
        public TipoOperacion Operation { get => operacion; }
         }