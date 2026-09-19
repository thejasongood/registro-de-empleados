namespace RegistroEmpleados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            int idActual = 1;
            string opcion;

            do
            {
                opcion = MostrarMenu();

                switch (opcion)
                {
                    case "1":
                        RegistrarEmpleado(empleados, ref idActual);
                        break;

                    case "2":
                        MostrarEmpleados(empleados);
                        break;

                    case "3":
                        BuscarPorNombre(empleados);
                        break;

                    case "4":
                        MostrarFactorial();
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != "5");
        }

        private static void MostrarEmpleados(List<Empleado> empleados)
        {
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            decimal totalNomina = 0;

            Console.WriteLine(
                $"{"Id",-3} {"Nombre",-20} {"Salario",10} {"Horas",-6} {"Pago Total",12}");

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado);
                totalNomina = totalNomina + empleado.PagoTotal();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL DE NÓMINA: Q {totalNomina:N2}");
        }

        private static string MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=== REGISTRO DE EMPLEADOS ===");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Listar empleados");
            Console.WriteLine("3. Buscar empleado");
            Console.WriteLine("4. Calcular factorial");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            return Console.ReadLine();
        }

        private static void RegistrarEmpleado(List<Empleado> empleados, ref int idActual)
        {
            Console.Write("Nombre: ");
            string nombreEmpleado = Console.ReadLine().Trim();

            Console.Write("Salario base: ");
            bool salarioValido = decimal.TryParse(
                Console.ReadLine(),
                out decimal salario);

            Console.Write("Horas extra: ");
            bool horasValidas = int.TryParse(
                Console.ReadLine(),
                out int horas);

            if (string.IsNullOrWhiteSpace(nombreEmpleado)
                || !salarioValido
                || salario <= 0
                || !horasValidas
                || horas < 0)
            {
                Console.WriteLine("Datos inválidos.");
                return;
            }

            empleados.Add(new Empleado
            {
                Id = idActual,
                Nombre = nombreEmpleado,
                SalarioBase = salario,
                HorasExtra = horas
            });

            idActual++;

            Console.WriteLine("Empleado agregado.");
        }

        private static void BuscarPorNombre(List<Empleado> empleados)
        {
            Console.Write("Nombre a buscar: ");

            string busqueda = Console.ReadLine().Trim().ToUpper();
            bool existe = false;

            foreach (Empleado empleado in empleados)
            {
                if (empleado.Nombre.ToUpper().Contains(busqueda))
                {
                    Console.WriteLine(empleado);
                    existe = true;
                }
            }

            if (!existe)
            {
                Console.WriteLine("Sin coincidencias.");
            }
        }

        private static void MostrarFactorial()
        {
            Console.Write("Número (entero, 0 o mayor): ");

            bool valido = int.TryParse(
                Console.ReadLine(),
                out int numero);

            if (!valido || numero < 0)
            {
                Console.WriteLine("Dato inválido.");
                return;
            }

            int resultado = Factorial(numero);

            Console.WriteLine($"{numero}! = {resultado}");
        }

        private static int Factorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }

            return numero * Factorial(numero - 1);
        }
    }
}