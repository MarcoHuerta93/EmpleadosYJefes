using System;
namespace EmpleadosYJefes
{
    class Pasante:Empleado
    {

        //Propiedades
        public int HorasDeTrabajo { get; set; }
        public int HorasDeEscuela { get; set; }

        //Constructor
        public  Pasante(int horasDeTrabajo, int horasDeEscuela, string nombre, string apellido, int salario): base(nombre, apellido, salario)
        {
            this.HorasDeEscuela = horasDeEscuela;
            this.HorasDeTrabajo = horasDeTrabajo;
        }


        //Método
        public void Aprender()
        {
            Console.WriteLine("Estor aprendiendo durante {0} horas", HorasDeEscuela);
        }

        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando durante {0} horas" , HorasDeTrabajo);
        }

    }
}
