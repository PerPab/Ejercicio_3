using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class EmpleadoQuincenal : Empleado
    {

        
        public EmpleadoQuincenal(string name, int age) // constructor
        {

            this.name = name;
            this.age = age;
           


        }

        public void CalcularSalario(double costoUnidadMinima)
        {
            double valor = (40 / 7) * costoUnidadMinima;
            double salario = valor * MostrarDiasTrabajados();
            this.salario = salario;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {this.name}");
            Console.WriteLine($"Dias trabajados: {MostrarDiasTrabajados()}");
            Console.WriteLine($"Salario: $ {salario}");

        }







    }
}
