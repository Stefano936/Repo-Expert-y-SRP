using System;

namespace SRP
{
    public class Sector
    {
        public string LibrarySector { get ; set; }

        public Shelve Shelve { get ; set; }
        public Sector(String sector, Shelve shelve)
        {
            this.LibrarySector = sector;
            this.Shelve = shelve;

        }
    }
}

/* Se puede ver como no cumple con el principio de SRP, debido a que tiene más de una responsabilidad,
por lo que se debería de crear una clase aparte (class Shelve y class Sector) para saber donde se guarda el libro (Sector y Shelve), ya que 
esta clase (class Book) no debería ser responsable de esta informacion */