using System;

namespace GestionEmpleados
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\t\t-----------------Gestión de Empleados-----------------\n");

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Ingresar Información para Empleado");
                Console.WriteLine("2. Ingresar Información para Gerente");
                Console.WriteLine("3. Salir");
                Console.Write("\nIngrese el número de la opción deseada: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Ingresar información para Empleado
                        IngresarInformacionEmpleado();
                        break;

                    case "2":
                        // Ingresar información para Gerente
                        IngresarInformacionGerente();
                        break;

                    case "3":
                        salir = true;
                        Console.WriteLine("Gracias. Vuelva Pronto....");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");
                        break;
                }
            }
        }

        static void IngresarInformacionEmpleado()
        {
            Console.WriteLine("\nIngresando información para Empleado:");

            string nombreEmpleado = PedirString("\tIngrese el nombre del empleado: ");
            decimal salarioEmpleado = PedirDecimal("\tIngrese el salario del empleado: ");

            // Crear instancia de Empleado
            Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

            // Mostrar menú
            MostrarMenu(empleado, null);
        }

        static void IngresarInformacionGerente()
        {
            Console.WriteLine("\nIngresando información para Gerente:");

            string nombreGerente = PedirString("\tIngrese el nombre del gerente: ");
            decimal salarioGerente = PedirDecimal("\tIngrese el salario del gerente: ");
            string departamentoGerente = PedirString("\tIngrese el departamento del gerente: ");

            // Crear instancia de Gerente
            Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);

            // Mostrar menú
            MostrarMenu(null, gerente);
        }

        static string PedirString(string mensaje)
        {
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Error: Debes ingresar un valor válido.");
                }
            } while (string.IsNullOrEmpty(entrada));

            return entrada;
        }

        static decimal PedirDecimal(string mensaje)
        {
            decimal entrada;
            bool entradaValida;

            do
            {
                Console.Write(mensaje);
                entradaValida = decimal.TryParse(Console.ReadLine(), out entrada);

                if (!entradaValida)
                {
                    Console.WriteLine("Error: Debes ingresar un valor numérico válido.");
                }
            } while (!entradaValida);

            return entrada;
        }

        static void MostrarMenu(Empleado empleado, Gerente gerente)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Mostrar Información del Empleado");
                Console.WriteLine("2. Mostrar Información del Gerente");
                Console.WriteLine("3. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Mostrar información del empleado
                        if (empleado != null)
                        {
                            Console.WriteLine("\nInformación del Empleado:");
                            empleado.MostrarInformacion();
                        }
                        else
                        {
                            Console.WriteLine("No hay información de empleado ingresada.");
                        }
                        break;

                    case "2":
                        // Mostrar información del gerente
                        if (gerente != null)
                        {
                            Console.WriteLine("\nInformación del Gerente:");
                            gerente.MostrarInformacion();
                        }
                        else
                        {
                            Console.WriteLine("No hay información de gerente ingresada.");
                        }
                        break;

                    case "3":
                        salir = true;
                        Console.WriteLine("Volviendo al menú principal.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }
    }
}
