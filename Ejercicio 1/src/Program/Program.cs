using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            Shelve shelve1 = new Shelve("7",book1);
            Shelve shelve2 = new Shelve("3",book2);

            Sector sector1 = new Sector("A",shelve1);
            Sector sector2 = new Sector("B",shelve2);

        }
    }
}

/*   book1.Shelve("A","7");
book2.Shelve("B","3");    */
/*

1. git add .                        (estar en src)
2. git commit -m "Ejercicio 1"
3. git push 

*/