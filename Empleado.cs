using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class Empleado
    {

        public string name;
        public int age;
        private int DiasTrabajados { get; set; }
        public double salario;




        public virtual void MostrarSAC(double salario)
        {
            double sac = salario / 2;

            Console.WriteLine($"El SAC es de ${sac}");
        }

        public void Fichar()
        {
            this.DiasTrabajados++;
        }

        public virtual int MostrarDiasTrabajados()
        {
            return this.DiasTrabajados;
        }

       

        

    }




}
