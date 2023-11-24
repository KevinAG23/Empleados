using System;

namespace GestionEmpleados
{
    public class Gerente : Empleado, IMostrarInformacion
    {
        public string Departamento { get; set; }

        public Gerente(string nombre, decimal salario, string departamento)
            : base(nombre, salario)
        {
            Departamento = departamento;
        }

        public override decimal CalcularSalarioAnual()
        {
            return base.CalcularSalarioAnual();
        }

        public new void MostrarInformacion()
        {
            Console.WriteLine($"\tNombre: {Nombre},\n\tSalario: {Salario},\n\tSalario Anual: {CalcularSalarioAnual()}, \n\tDepartamento: {Departamento}");
        }
    }
}
