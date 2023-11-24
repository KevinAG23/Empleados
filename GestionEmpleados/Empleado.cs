using System;

namespace GestionEmpleados
{
    public class Empleado : IMostrarInformacion
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public virtual decimal CalcularSalarioAnual()
        {
            return Salario * 12;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"\n\tNombre: {Nombre}, \n\tSalario: {Salario}, \n\tSalario Anual: {CalcularSalarioAnual()}");
        }
    }
}
