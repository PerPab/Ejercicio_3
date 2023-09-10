using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //3.Sean Empleados de una multinacional en el que hay varios tipos de ellos. El de jornada
            //mensual que cobra un sueldo quincenal y el de monto por horas.Se conoce de ellos el
            //nombre, la edad.
            //a.Crear un programa que represente estos empleados.Ambos pueden calcular su
            //salario mensual sabiendo el costo de la unidad mínima de trabajo
            //(quincena / horas).El de horas considerar para el cálculo 40 horas semanales y 4
            //semanas.
            //b.Mostrar el SAC correspondiente(recuerde que es el 50 % del sueldo).
            //c.Ambos tipos de empleados deben fichar todos los días, por lo que genere los
            //métodos necesarios que registre la fichada(cantidad variable) y pueda indicar
            //cuántos días trabajó en el mes(considere la variable que cuenta fichadas como
            //privada).Este ejercicio es independiente a la cantidad de horas trabajadas.
            //d.Desarrollar un programa tal que se pida el nombre, valor de hora quincenal, el de
            //por hora, la cantidad de veces que fichó cada uno y mostrar por pantalla los
            //sueldos y las fichadas.


            EmpleadoHoras e1 = new EmpleadoHoras("Juan", 23);

            e1.Fichar();
            e1.Fichar();
            e1.Fichar();
            e1.Fichar();
            e1.Fichar();

            e1.CalcularSalario(1020);

            e1.MostrarInformacion();


        }
    }
}
