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
                        EjecutarMotor(motor);
                    }

                    Console.WriteLine("Selecciona otro motor o presiona 0 para salir:");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                }
            }
        }

        static void EjecutarMotor(Motor motor)
        {
            motor.Arrancar();
            motor.Acelerar();
            motor.Detener();
            motor.CargarCombustible();
        }
    }
}
