using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        public AutoDeCombustion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo) { }

        //Definicion de los publicos

        public override void frenar()
        {
            base.frenar();
            NiveldelTanque --;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Console.WriteLine("El auto va a {0} km/h:" + cuanto);
        }

        public void luces(bool estado)
        {
            if (estado == true)
            {
                Console.WriteLine("Las luces estan encendidas");
            }
            else
            {
                Console.WriteLine("Las luces estan apagadas");
            }
        }

        //Definicion de los privados
        int NiveldelTanque;

        private void LlenarTanque(int cuanto)
        {
            NiveldelTanque =+ cuanto;

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

        private void Apagar()
        {
            Console.WriteLine("El auto esta apagado");

        }
        
        private void Encender()
        {
            Console.WriteLine("El auto esta encendido");
        }
    }
}

