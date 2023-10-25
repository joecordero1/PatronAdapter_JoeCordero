using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Joe_Cordero
{
    public class MotorElectrico
    {
        bool _conectado;
        bool _activo;
        bool _moviendo;

        public void Conectar()
        {
            if(_conectado)
            {
                Console.WriteLine("No se puede conectar un motor electrico ya conectado");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("Motor conectado");
            }
        }

        public void Activar()
        {
            if (!_conectado)
            {
                Console.WriteLine("No se puede activar un motor electrico no conectado");
            }
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado");
            }
        }

        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("El motor debe estar conectado y activo");
            }
        }

        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
            {
                Console.WriteLine("No se puede parar un vehiculo que no está en movimiento");
            }
        }

        public void Desconectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Motor electrico desconectado");
            }
            else
            {
                Console.WriteLine("No se puede desconectar un vehiculo que no está conectado");
            }
        }

        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor electrico desactivado");
            }
            else
            {
                Console.WriteLine("No se puede desactivar un vehiculo que no está activado");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor electrico cargando batería");
            }
            else
            {
                Console.WriteLine("Para enchufar, primero desactive el motor electrico");
            }
        }

    }
}
