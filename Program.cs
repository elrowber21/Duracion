using System;

namespace Dur
{
    class Duracion
    {
        //public int horas;
        //public int minutos;
        public decimal segundos;

        public Duracion(decimal s)
        {
            segundos=s;
        }
        public override string ToString()
        {
            return String.Format("{0}", segundos);
        }
        public static Duracion operator +(Duracion x, Duracion y)
        {
            decimal segundos=x.segundos+y.segundos;
            return new Duracion(segundos);
        }
        public static Duracion operator /(Duracion a,Duracion b)
        {
            decimal segundos=a.segundos/b.segundos;
            return new Duracion(segundos);
        }
        public static Duracion operator %(Duracion m, Duracion n)
        {
            decimal segundos=m.segundos%n.segundos;
            return new Duracion(segundos);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
           Duracion Tiempo1= new Duracion(3600);
           Duracion Tiempo2= new Duracion(9000);
           Duracion ParaMinutos= new Duracion(60);
           Duracion ParaHora= new Duracion(3600);
           

           Duracion TotalSegundos=Tiempo1+Tiempo2;

           Duracion minutos=TotalSegundos/ParaMinutos;
           Duracion horas= TotalSegundos/ParaHora;
           

           Console.WriteLine("Tiempo 1: "+Tiempo1+" segundos");
           Console.WriteLine("Tiempo 2: "+Tiempo2+" segundos");
           Console.WriteLine("Total: "+TotalSegundos+" segundos");
           Console.WriteLine("Total : "+minutos+" minutos");
           Console.WriteLine("Total : "+horas+" horas");           
        }
    }
}
