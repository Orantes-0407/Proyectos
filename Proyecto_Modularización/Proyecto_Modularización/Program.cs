using System.Linq.Expressions;

Console.WriteLine("Proyecto Modularización");
Console.WriteLine("\n Selecciona una opcion");
int opcion = 0;
while (opcion != 11)
{
    Console.WriteLine("\n1. Calculadora Basica");
    Console.WriteLine("2. Validacion de Contrasenia");
    Console.WriteLine("3. Numeros primos");
    Console.WriteLine("4. Suma de numeros pares");
    Console.WriteLine("5. Conversion de temperatura");
    Console.WriteLine("6.Contador de vocales");
    Console.WriteLine("7. Calculo de factorial");
    Console.Write("8.Juego de Adivinanza");
    Console.WriteLine("\n9. Paso por referencia");
    Console.WriteLine("10. Tabla de multiplicar");
    Console.WriteLine("11. Salir");

    string input = Console.ReadLine();
    if (!int.TryParse(input, out opcion))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
        continue;
    }

    Console.Clear();
    switch (opcion)
    {
        case 1:
            double num1;
            double num2;
            double suma, resta, multiplicacion, division;
            Console.WriteLine("Calculadora Basica");

            Console.WriteLine("Por favor, elige la operacion que deseas realizar");
            bool elegir_opcion = true;
            while (elegir_opcion)
            {
                Console.WriteLine("1. REALIZAR SUMA");
                Console.WriteLine("2. REALIZAR RESTA");
                Console.WriteLine("3. REALIZAR MULTIPLICACION");
                Console.WriteLine("4. REALIZAR DIVISION");

                int operacion;
                if (int.TryParse(Console.ReadLine(), out operacion))
                {
                    if (operacion < 1 || operacion > 4)
                    {
                        Console.WriteLine("Opción no válida. Regresando al menú principal...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine("Ingrese el primer numero");
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para el primer número:");
                    }

                    Console.WriteLine("Ingrese el segundo numero");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para el segundo número:");
                    }

                    switch (operacion)
                    {
                        case 1:
                            suma = num1 + num2;
                            Console.WriteLine($"El resultado es: {suma}");
                            elegir_opcion = false;
                            break;
                        case 2:
                            resta = num1 - num2;
                            Console.WriteLine($"El resultado es: {resta}");
                            elegir_opcion = false;
                            break;
                        case 3:
                            multiplicacion = num1 * num2;
                            Console.WriteLine($"El resultado es: {multiplicacion}");
                            elegir_opcion = false;
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                division = num1 / num2;
                                Console.WriteLine($"El resultado es: {division}");
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por cero. Intente otra division.");
                            }
                            elegir_opcion = false;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la operación:");
                }
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            int contrasena;
            const int contrasenaCorrecta = 1234;
            do
            {
                Console.WriteLine("Validacion de Contrasenia");
                Console.WriteLine("Por favor escribe una contraseña: ");
                string contrasenaInput = Console.ReadLine();
                if (int.TryParse(contrasenaInput, out contrasena) && contrasena == contrasenaCorrecta)
                {
                    Console.WriteLine("Contraseña correcta");
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
                }
            } while (true);

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Numeros Primos");
            Console.WriteLine("Por favor ingresa un numero");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
            }

            if (EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            int numeroIngresado;
            int sumaPares = 0;
            do
            {
                Console.WriteLine("Ingrese un numero (0 para terminar):");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
                }

                if (numeroIngresado % 2 == 0)
                {
                    sumaPares += numeroIngresado;
                }
            } while (numeroIngresado != 0);

            Console.WriteLine($"La suma de todos los numeros pares ingresados es de: {sumaPares}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Console.WriteLine("Conversion de temperatura");
            Console.WriteLine("Elige la opción deseada:");
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Fahrenheit a Celsius");

            int opcionConversion;
            if (int.TryParse(Console.ReadLine(), out opcionConversion))
            {
                double temperatura;
                switch (opcionConversion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
                        while (!double.TryParse(Console.ReadLine(), out temperatura))
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la temperatura en grados Celsius:");
                        }
                        double fahrenheit = CelsiusAFahrenheit(temperatura);
                        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
                        while (!double.TryParse(Console.ReadLine(), out temperatura))
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido para la temperatura en grados Fahrenheit:");
                        }
                        double celsius = FahrenheitACelsius(temperatura);
                        Console.WriteLine($"La temperatura en grados Celsius es: {celsius}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Regresando al menú principal...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Regresando al menú principal...");
            }

            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 6:
            Console.WriteLine("Contador de vocales");
            Console.WriteLine("Por favor ingresa una frase:");
            string frase = Console.ReadLine();
            int numeroVocales = ContarVocales(frase);
            Console.WriteLine($"La frase contiene {numeroVocales} vocales.");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 7:
            Console.WriteLine("Calculo de factorial");
            Console.WriteLine("Por favor ingresa un numero entero:");
            int numeroFactorial;
            while (!int.TryParse(Console.ReadLine(), out numeroFactorial))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
            }
            long factorial = 1;
            for (int i = 1; i <= numeroFactorial; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {numeroFactorial} es: {factorial}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 8:
            Console.WriteLine("Juego de Adivinanza");
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int intentos = 0;
            int numeroUsuario;
            do
            {
                Console.WriteLine("Adivina el número (1-100):");
                while (!int.TryParse(Console.ReadLine(), out numeroUsuario))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor.");
                }
                else if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor.");
                }
                intentos++;
            } while (numeroUsuario != numeroAleatorio);
            Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 9:
            Console.WriteLine("Paso por referencia");
            int numeroReferencia = 10;
            Console.WriteLine($"Valor antes de llamar al método: {numeroReferencia}");
            PasoPorReferencia(ref numeroReferencia);
            Console.WriteLine($"Valor después de llamar al método: {numeroReferencia}");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 10:
            Console.WriteLine("Tabla de multiplicar");
            Console.WriteLine("Por favor ingresa un número entero:");
            int numeroTabla;
            while (!int.TryParse(Console.ReadLine(), out numeroTabla))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido:");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
            }
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 11:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("Presione cualquier tecla para regresar al menú principal...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

static bool EsPrimo(int numero)
{
    if (numero <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}

static double CelsiusAFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double FahrenheitACelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static int ContarVocales(string texto)
{
    int contador = 0;
    string vocales = "aeiouAEIOU";
    foreach (char c in texto)
    {
        if (vocales.Contains(c))
        {
            contador++;
        }
    }
    return contador;
}


static void PasoPorReferencia(ref int numero)
{
    numero += 10;
}





