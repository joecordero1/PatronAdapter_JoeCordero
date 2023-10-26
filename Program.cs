using Adapter_Joe_Cordero;
using System;

namespace PatrónAdapter_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = null;

            Console.WriteLine("Selecciona un motor:");
            Console.WriteLine("1. MotorNaftero");
            Console.WriteLine("2. MotorDiesel");
            Console.WriteLine("3. MotorElectricoAdapter");
            Console.WriteLine("0. Salir");

            int opcion;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            motor = new MotorNaftero();
                            break;
                        case 2:
                            motor = new MotorDiesel();
                            break;
                        case 3:
                            motor = new MotorElectricoAdapter();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                            break;
                    }

                    if (motor != null)
                    {
                        MostrarSubMenuMotor(motor);
                    }

                    Console.WriteLine("Selecciona otro motor o presiona 0 para salir:");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                }
            }
        }

        static void MostrarSubMenuMotor(Motor motor)
        {
            int opcion;
            while (true)
            {
                Console.WriteLine("Selecciona una acción para el motor:");
                Console.WriteLine("1. Arrancar");
                Console.WriteLine("2. Acelerar");
                Console.WriteLine("3. Detener");
                Console.WriteLine("4. Cargar Combustible");
                Console.WriteLine("0. Volver al menú anterior");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            motor.Arrancar();
                            break;
                        case 2:
                            motor.Acelerar();
                            break;
                        case 3:
                            motor.Detener();
                            break;
                        case 4:
                            motor.CargarCombustible();
                            break;
                        case 0:
                            return; // Volver al menú anterior
                        default:
                            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                }
            }
        }
    }
}
