using System;

namespace Dur
{
    class Duracion
    {
        //public int horas;
        //public int minutos;
        public int segundos;

        public Duracion(int s)
        {
            segundos=s;
        }
        public override string ToString()
        {
            return String.Format("{0}", segundos);
        }
        public static Duracion operator +(Duracion x, Duracion y)
        {
            int segundos=x.segundos+y.segundos;
            return new Duracion(segundos);
        }
        


    }
    class Program
    {
        static void Main(string[] args)
        {
           Duracion Tiempo1= new Duracion(30);
           Duracion Tiempo2= new Duracion(40);
          
           Duracion TotalSegundos=Tiempo1+Tiempo2;
           

           Console.WriteLine("Tiempo 1: "+Tiempo1+" segundos");
           Console.WriteLine("Tiempo 2: "+Tiempo2+" segundos");
           Console.WriteLine("Total: "+TotalSegundos+" segundos");

           
        }
    }
}
