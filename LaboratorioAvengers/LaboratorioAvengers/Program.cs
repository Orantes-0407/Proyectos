int opcion;
crearCarpetaInicial(); // Crear la carpeta ProyectosSecretos al iniciar el programa
do
{
    Console.Clear();
    Console.WriteLine("1. Archivo");
    Console.WriteLine("2. Mostrar inventos");
    Console.WriteLine("3. Agregar inventos");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out opcion))
    {
        Console.Clear();
        Console.WriteLine("Opcion no valida");
        Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
        Console.ReadKey();
        continue;
    }
    switch (opcion)
    {
        case 1:
            Console.Clear();
            mostrarSubmenuArchivo();
            break;
        case 2:
            Console.Clear();
            leerLineas();
            break;
        case 3:
            Console.Clear();
            agregarInventos();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Saliendo del programa");
            ResetearPrograma();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opcion no valida");
            break;
    }
    if (opcion != 4)
    {
        Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
        Console.ReadKey();
    }
} while (opcion != 4);

void mostrarSubmenuArchivo()
{
    int subOpcion;
    do
    {
        Console.Clear();
        Console.WriteLine("1. Crear archivo");
        Console.WriteLine("2. Copiar archivo");
        Console.WriteLine("3. Mover archivo");
        Console.WriteLine("4. Crear carpeta");
        Console.WriteLine("5. Verificar si existe archivo");
        Console.WriteLine("6. Eliminar archivo");
        Console.WriteLine("7. Listar archivos");
        Console.WriteLine("8. Volver al menú principal");
        Console.WriteLine("Ingrese una opcion: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out subOpcion))
        {
            Console.Clear();
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("\nPresione cualquier tecla para volver al submenú...");
            Console.ReadKey();
            continue;
        }
        switch (subOpcion)
        {
            case 1:
                Console.Clear();
                crearArchivo();
                break;
            case 2:
                Console.Clear();
                copiarArchivo();
                break;
            case 3:
                Console.Clear();
                moverArchivo();
                break;
            case 4:
                Console.Clear();
                crearCarpeta();
                break;
            case 5:
                Console.Clear();
                verificarArchivo();
                break;
            case 6:
                Console.Clear();
                eliminarArchivo();
                break;
            case 7:
                Console.Clear();
                listarArchivos();
                break;
            case 8:
                Console.Clear();
                Console.WriteLine("Volviendo al menú principal");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opcion no valida");
                break;
        }
        if (subOpcion != 8)
        {
            Console.WriteLine("\nPresione cualquier tecla para volver al submenú...");
            Console.ReadKey();
        }
    } while (subOpcion != 8);
}

// FUNCION PARA CREAR UN ARCHIVO DE TEXTO
void crearArchivo()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    if (File.Exists(path))
    {
        Console.WriteLine("El archivo ya existe.");
        return;
    }
    string contenido = "Inventos de Tony Stark";
    try
    {
        File.WriteAllText(path, contenido);
        Console.WriteLine("Archivo creado");
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void leerLineas()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    try
    {
        if (File.Exists(path))
        {
            string[] contenido = File.ReadAllLines(path);
            foreach (string linea in contenido)
            {
                Console.WriteLine(linea);
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void agregarInventos()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    Console.WriteLine("Ingrese el nombre del invento: ");
    string invento = Console.ReadLine();

    try
    {
        if (File.Exists(path))
        {
            string[] contenido = File.ReadAllLines(path);
            if (Array.Exists(contenido, element => element.Equals(invento, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("El invento ya existe.");
            }
            else
            {
                File.AppendAllText(path, Environment.NewLine + invento);
                Console.WriteLine("Invento agregado");
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void copiarArchivo()
{
    string sourcePath = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    string destinationPath = "C:\\LaboratorioAvengers\\Backup\\inventos.txt";
    try
    {
        if (File.Exists(sourcePath))
        {
            Directory.CreateDirectory("C:\\LaboratorioAvengers\\Backup");
            File.Copy(sourcePath, destinationPath, true);
            Console.WriteLine("Archivo copiado a la carpeta Backup");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void moverArchivo()
{
    string sourcePath = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    string destinationPath = "C:\\LaboratorioAvengers\\ArchivosClasificados\\inventos.txt";
    try
    {
        if (File.Exists(sourcePath))
        {
            Directory.CreateDirectory("C:\\LaboratorioAvengers\\ArchivosClasificados");
            File.Move(sourcePath, destinationPath);
            Console.WriteLine("Archivo movido a la carpeta ArchivosClasificados");
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void crearCarpeta()
{
    string path = "C:\\LaboratorioAvengers\\ProyectosSecretos";
    if (Directory.Exists(path))
    {
        Console.WriteLine("La carpeta ya existe.");
        return;
    }
    try
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("Carpeta ProyectosSecretos creada");
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void crearCarpetaInicial()
{
    string path = "C:\\LaboratorioAvengers\\ProyectosSecretos";
    try
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Carpeta ProyectosSecretos creada al iniciar el programa");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void verificarArchivo()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    if (File.Exists(path))
    {
        Console.WriteLine("El archivo existe.");
    }
    else
    {
        Console.WriteLine("El archivo no existe.");
    }
}

void eliminarArchivo()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
    try
    {
        if (File.Exists(path))
        {
            copiarArchivo(); // Hacer una copia de seguridad antes de eliminar
            File.Delete(path);
            Console.WriteLine("Archivo eliminado");
            eliminarCarpetaProyectosSecretos(); // Eliminar la carpeta ProyectosSecretos
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void eliminarCarpetaProyectosSecretos()
{
    string path = "C:\\LaboratorioAvengers\\ProyectosSecretos";
    try
    {
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            Console.WriteLine("Carpeta ProyectosSecretos eliminada");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void listarArchivos()
{
    string path = "C:\\LaboratorioAvengers\\LaboratorioAvengers";
    try
    {
        if (Directory.Exists(path))
        {
            string[] archivos = Directory.GetFiles(path);
            Console.WriteLine("Archivos en la carpeta LaboratorioAvengers:");
            foreach (string archivo in archivos)
            {
                Console.WriteLine(Path.GetFileName(archivo));
            }
        }
        else
        {
            Console.WriteLine("La carpeta no existe.");
        }
    }
    catch (Exception err)
    {
        Console.WriteLine("Error: " + err.Message);
    }
}

void ResetearPrograma()
{
    try
    {
        string[] directorios = { "C:\\LaboratorioAvengers\\Backup", "C:\\LaboratorioAvengers\\ArchivosClasificados", "C:\\LaboratorioAvengers\\ProyectosSecretos" };
        foreach (string directorio in directorios)
        {
            if (Directory.Exists(directorio))
            {
                Directory.Delete(directorio, true);
            }
        }
        string archivo = "C:\\LaboratorioAvengers\\LaboratorioAvengers\\inventos.txt";
        if (File.Exists(archivo))
        {
            File.Delete(archivo);
        }
        Console.WriteLine("Programa reseteado a su estado inicial.");
    }
    catch (Exception err)
    {
        Console.WriteLine("Error al resetear el programa: " + err.Message);
    }
}















