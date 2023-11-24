Aplicación de Programación Orientada a Objetos.

Estructura del programa:

Program.cs: Este archivo contiene el punto de entrada principal para la aplicación. Aquí se encuentra la función Main, que inicia la ejecución del programa.

Empleado.cs: Define la clase Empleado, que representa a un empleado con propiedades como nombre, salario, y métodos para calcular el salario anual y mostrar información.

Gerente.cs: Hereda de Empleado y agrega una propiedad adicional para el departamento que supervisa. Implementa el método para calcular el salario anual y muestra información.

IMostrarInformacion.cs: Define la interfaz IMostrarInformacion que incluye un método MostrarInformacion. Ambas clases (Empleado y Gerente)

Funcionalidades principales: Ingreso de Datos: El programa permite al usuario ingresar información para un empleado o un gerente. Solicita el nombre y salario común a ambos, y el departamento en caso de un gerente. Cálculo de Salario Anual: Tanto la clase Empleado como la clase Gerente tienen métodos para calcular el salario anual.

Interfaz de Mostrar Información: Ambas clases implementan la interfaz IMostrarInformacion, que incluye un método para mostrar la información del empleado o gerente.

Menú de Opciones: Después de ingresar los datos, se presenta un menú que permite al usuario seleccionar si desea mostrar información del empleado, del gerente o salir del programa.

Polimorfismo: El programa utiliza el polimorfismo a través de la interfaz IMostrarInformacion. Esto permite tratar instancias de Empleado y Gerente de manera uniforme cuando se muestran sus detalles.

Instrucciones para el Usuario:

Inicio: Al iniciar la aplicación, se presenta un menú principal con opciones para ingresar información para un empleado, un gerente o salir del programa.

Ingreso de Datos: El usuario selecciona la opción deseada e ingresa la información solicitada.

Menú de Opciones: Después de ingresar la información, se presenta un menú con opciones para mostrar información del empleado, del gerente o salir del menú.

Mostrar Información: Al seleccionar la opción correspondiente, se mostrará la información del empleado o del gerente ingresado. Repetición o Salida:

Después de mostrar la información, el usuario puede optar por repetir el proceso para otro empleado o gerente, o salir del programa.

Ejecucion:

    Clonar el repositorio.
    Abrir Visual Studio:
    Abrir Archivo Program.cs:
    Compilar y Ejecutar: Haz clic en "Iniciar" (botón verde) o presiona F5 para compilar y ejecutar la aplicación.
    Interactuar con el Menú: • La aplicación te mostrará un menú inicial. • Ingresa 1 para ingresar información de un empleado o 2 para un gerente.
    Ingresar Datos: • Sigue las instrucciones para ingresar nombre, salario y, para un gerente, el departamento.
    Mostrar Información: • Después de ingresar datos, se mostrará un menú con opciones para mostrar información del empleado o gerente.
    Repetir o Salir: • Puedes repetir el proceso para ingresar información de otro empleado o gerente. • Ingresa 3 para salir del programa.
