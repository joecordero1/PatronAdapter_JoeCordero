using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Joe_Cordero
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando motor naftero");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando motor naftero");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando gasolina a motor naftero");
        }
        public override void Detener()
        {
            Console.WriteLine("Deteniendo motor naftero");
        }
    }
}
