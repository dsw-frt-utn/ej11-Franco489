namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private static List<Alumno> _alumnos { get; } = new List<Alumno>();


    public static void Agregar (Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public static List<Alumno> MostrarAlumnos()
    {
        return _alumnos;
    }

    public static Alumno? BuscarAlumno (string nombre)
    {
        foreach (Alumno alumno in _alumnos)
        {
            if(alumno.Nombre == nombre) 
                return alumno;
        }
        return null;
    }

    public static List<Alumno> EliminarAlumno (Alumno alumno)
    {
        _alumnos.Remove(alumno);
        return _alumnos;
    }

    public static List<Alumno> EliminarPorPosicion(int posicion)
    {
        _alumnos.RemoveAt(posicion);
        return _alumnos;
    }

}
