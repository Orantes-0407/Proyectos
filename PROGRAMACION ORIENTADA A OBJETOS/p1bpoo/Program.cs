
using p1bpoo.MisClases;

Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

miBYD.acelerar(150);
miBYD.frenar();   



