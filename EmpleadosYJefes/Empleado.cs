using System;
namespace EmpleadosYJefes
{
    class Empleado
    {

        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }

        //Constructores
        public Empleado()
        {
            Nombre = "Marco";
            Apellido = "Huerta";
            Salario = 20000;
        }

        //Constructor parametrizado

        public Empleado(string nombre, string apellido, int salario)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }


        //Métodos
        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }

        public void Descansar()
        {
            Console.WriteLine("Estoy descansando");
        }
    }
}
