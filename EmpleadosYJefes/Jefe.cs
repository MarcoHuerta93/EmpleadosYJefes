using System;
namespace EmpleadosYJefes
{
     class Jefe:Empleado
    {

        //Propiedades

        public string AutoDeEmpresa { get; set; }


        //Constructor
        public Jefe(string autoDeEmpresa, string nombre, string apellido, int salario):base(nombre,apellido,salario)
        {
            this.AutoDeEmpresa = autoDeEmpresa;
        }

        //método
        public void Dirigir()
        {
            Console.WriteLine("Estoy liderando mi empresa");
        }

    }
}
