using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Joe_Cordero
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando motor diesel");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando motor diesel");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando gasolina a motor diesel");
        }
        public override void Detener()
        {
            Console.WriteLine("Deteniendo motor diesel");
        }
    }
}
