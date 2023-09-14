
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Xml;
using practica.entities;

public class LinqQueries
{
    List<Book> lstBooks = new List<Book>();
    public LinqQueries()
    {

        using (StreamReader reader = new StreamReader("books.json"))
        {
            String json = reader.ReadToEnd();
            this.lstBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions()
            { PropertyNameCaseInsensitive = true }) ?? new List<Book>();

        }

    }
    public IEnumerable<Book> AllCollection()
    {
        return lstBooks;
    }


    public IEnumerable<Book> LibrosDespues2000()
    {
        return from book in lstBooks where book.PublishedDate.Year >2000
         select book;
    }

    public IEnumerable<Book> LibrosAndroid(String palabra){
        return from book in lstBooks where (book.Title ?? String.Empty).Contains(palabra)/*&& book.PageCount > nroPagina*/ select book;
    }

     public IEnumerable<Book> LibrosAnd2005(){
        return from book in lstBooks where book.Title.Contains("Android") && book.PublishedDate.Year >2005  select book;
    }

    public IEnumerable<Book> LibrosAction250(){
        return from book in lstBooks where book.Title.Contains("Action") && book.PageCount> 250 select book;
    }

    public bool validarStatus (){
        bool status = lstBooks.All(book => book.Status.Length>0);
        return status;
    }

    public bool validarFecha(){
        bool libro2005= lstBooks.Any(book => book.PublishedDate.Year ==2005);
        return libro2005;
    }

    public IEnumerable<Book> fecha2005(){
        if(validarFecha()){
            return from book in lstBooks.(x => x.publishedDate.Year == validarFecha()) select book ;
        }
        return new List<Book>();
    }
}

    

