using App26092022.Utils;

namespace App26092022.Algorithms; 

public class Six : Algorithm {

    public Six() : base(
        "Sexto",
        "Construcción de una aplicación simple que permitirá a un usuario leer un libro cambiando de páginas. Esta debería permitir moverse a la siguiente página (si esta existe) si se presiona la tecla S, y permitirá ir a la página previa (si esta existe) después de presionar la tecla A."
        ) {
    }

    protected override void Execute() {
       var text = File.ReadAllText(@"D:\Escritorio\Work\UCC\App26092022\Algorithms\book.txt");
       var linedPages = new LinkedList<string>(text.Split("-*-"));
        var currentPage = linedPages.First;
        var index = 1;
        while(true) {
            Console.Clear();
            Console.WriteLine("Pagina:" + index+" de "+linedPages.Count);
            Console.WriteLine("-----------------------");
            Console.WriteLine(currentPage.Value);
            Console.WriteLine("-----------------------");
            Console.Write("Presione S para siguiente pagina o A para anterior o X para salir: ");
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.S) {
                if(currentPage.Next != null) {
                    currentPage = currentPage.Next;
                    index++;
                } 
            } else if(key.Key == ConsoleKey.A) {
                if(currentPage.Previous != null) {
                    currentPage = currentPage.Previous;
                    index--;
                }
            } else if(key.Key == ConsoleKey.X) {
                break;
            }
        }
          

    }
}