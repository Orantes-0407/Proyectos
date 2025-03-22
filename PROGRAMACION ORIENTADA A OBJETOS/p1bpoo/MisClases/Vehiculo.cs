using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        private int velocidad = 0;

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }

        public virtual void frenar()
        {
            for (int i = velocidad; i > 0; i =- 6 )
            {
                velocidad -= i;
                Console.WriteLine("La velocidad actual es de {0} km/h: " + velocidad);
            }
        }
    }
}
