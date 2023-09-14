using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.entities
{
    public class Book
    {
        String ? title ;
        int pageCount;
        DateTime publishedDate;
        String ? status;
        String [] ? authors;

        String [] ?  categorias;

        public string? Title { get => title; set => title = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public DateTime PublishedDate { get => publishedDate; set => publishedDate = value; }
        public string? Status { get => status; set => status = value; }
        public string[]? Authors { get => authors; set => authors = value; }
        public string[]? Categorias { get => categorias; set => categorias = value; }
    }
}