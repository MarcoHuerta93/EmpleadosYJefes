using System;

namespace EmpleadosYJefes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Empleado marco = new Empleado("Marco", "Huerta", 4000);
            marco.Trabajar();
            marco.Descansar();

            Jefe chuckNorris = new Jefe("Ferrari", "Chuck", "Norris", 999999);
            chuckNorris.Dirigir();
            

            Pasante antonio = new Pasante(15,30,"Antonio", "Huerta", 200);
            antonio.Trabajar();
            antonio.Aprender();


            Console.Read();
        }
    }
}
