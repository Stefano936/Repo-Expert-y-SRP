﻿using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
/* Se puede ver como no cumple con el principio de SRP, debido a que tiene más de una responsabilidad,
por lo que se debería de crear una clase aparte (class Shelve y class Sector) para saber donde se guarda el libro (Sector y Shelve), ya que 
esta clase (class Book) no debería ser responsable de esta informacion */