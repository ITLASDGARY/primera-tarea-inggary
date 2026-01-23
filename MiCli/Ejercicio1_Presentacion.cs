namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        string nombre = "Gary";
        string carrera = "Ingeniero Sistemas";
        string hobby = "Videojuegos";
        // TODO: Retorna un string con las tres variables en líneas separadas
        return $"{nombre}\n{carrera}\n{hobby}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
