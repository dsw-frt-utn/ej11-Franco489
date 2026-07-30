using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{

    private static List<Libro> _libros = Libro.CrearLista();

    public static Libro GetPrimero()
    {
        return _libros.First();
    }

    public static  Libro GetUltimo()
    {
        return _libros.Last();
    }

    public static decimal GetTotalPrecios()
    {
        return (from libro in _libros select libro.Precio).Sum();
    }

    public static decimal GetPromedioPrecios()
    {
        return (from libro in _libros select libro.Precio).Average();
    }

    public static List<Libro> GetListById()
    {
        return (from libro in _libros where libro.Id > 15 select libro).ToList();
    }

    public static List<string> GetLibros()
    {
        var librosEnumerados = from libro in _libros select (libro.Titulo, string.Format("{0:c}", libro.Precio));
        var libros = new List<string>();
        foreach (var libroEnum in librosEnumerados)
        {
            libros.Add(libroEnum.ToString());
        }
        return libros;
    }

    public static Libro GetMayorPrecio()
    {
        return (from libro in _libros orderby libro.Precio descending select libro).FirstOrDefault();
    }

    public static Libro GetMenorPrecio()
    {
        return (from libro in _libros orderby libro.Precio select libro).FirstOrDefault();
    }

    public static List<Libro> GetMayorPromedio()
    {
        return (from libro in _libros where libro.Precio > GetPromedioPrecios() select libro).ToList();
    }

    public static List<Libro> GetTituloDescendente()
    {
        return _libros.OrderByDescending(l => l.Titulo).ToList();
    }

}
