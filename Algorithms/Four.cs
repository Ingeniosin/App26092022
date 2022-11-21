using App26092022.Utils;

namespace App26092022.Algorithms; 

public class Four : Algorithm {

    public Four() : base("Cuarto", 
        "Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso al que se ingresaron separados por comas."
        ) {
    }

    protected override void Execute() {
        var list = new LinkedList<int>();
        for (var i = 1; i <= 10; i++) {
            list.AddLast(i);
        }
        Console.WriteLine("Normal: " + string.Join(", ", list));
        var reverse = new LinkedList<int>();
        var node = list.Last;
        while (node != null) {
            reverse.AddLast(node.Value);
            node = node.Previous;
        }
        
        Console.WriteLine("Reversa: " + string.Join(", ", reverse));
        
    }
}