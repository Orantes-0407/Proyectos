using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        public Motocicleta (int anio, string elColor, string elModelo) : base(anio, elColor, elModelo) { }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            int aceleracionmoto = cuanto + 10;

            Console.WriteLine("La motocicleta va a: " + aceleracionmoto +"km/h");
        }

        public override void frenar()
        {
            base.frenar();
        }

        //Propios

        public void CambiarCambio(int marcha)
        {
            if (marcha < 1 || marcha > 6)
            {
                Console.WriteLine("Numero de cambios entre 1 y 6.");
            }
            else
            {
                Console.WriteLine("Ahora: " +marcha + "es la nueva marcha");
            }
        }

        public void luces(int cual)
        {
            if (cual == 1)
            {
                Console.WriteLine("Las luces altas estan encendidas");
            }
            else if (cual == 2)
            {
                Console.WriteLine("Las luces bajas estan encendidas");
            }
            else
            {
                Console.WriteLine("Las luces estan apagadas");
            }
        }

        public void pito()
        {
            Console.WriteLine("Piiiiiip");
        }

            //privados
            int NiveldelTanque;

        private void LlenarTanque(int cuanto)
        {
            NiveldelTanque = +cuanto;

        }

        private void NivelDelTanque(int NiveldelTanque)
        {
            Console.WriteLine("El nivel del tanque es: " + NiveldelTanque);

            if (NiveldelTanque <= 20)
            {
                Console.WriteLine("El tanque esta casi vacio");
            }
            else if (NiveldelTanque <= 60)

            {
                Console.WriteLine("El tanque esta a la mitad");
            }
            else if (NiveldelTanque <= 80)
            {
                Console.WriteLine("El tanque esta  lleno");
            }
            else if (NiveldelTanque <= 100)
            {
                Console.WriteLine("El tanque esta lleno");
            }
        }

        private void Encender()
        {
            Console.WriteLine("El auto esta encendido");
        }
    }
}
