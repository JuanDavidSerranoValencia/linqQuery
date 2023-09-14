using System.ComponentModel.Design;
using System.Linq;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using practica.entities;
internal class Program
{
    private static void Main(string[] args)
    {  
        Console.WriteLine("Hello, World!");
        LinqQueries queries = new LinqQueries();
        ImprimirValores(queries.AllCollection());
        ImprimirValores(queries.LibrosDespues2000());
        ImprimirValores(queries.LibrosAndroid("Android"));
        ImprimirValores(queries.LibrosAnd2005());
        ImprimirValores(queries.LibrosAction250());
        Console.WriteLine(queries.validarStatus() ? "Esta activo":"Esincativo") ;
        ImprimirValores(queries.validarFecha());

    }

    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-78} {1,7} {2,20}", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            registros += 1;
            Console.WriteLine("{0,-78} {1,7} {2,20} ", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
            
        }

    }

    
}
