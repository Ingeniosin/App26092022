using App26092022.Utils;

namespace App26092022.Algorithms;

public class One : Algorithm {

    public One() : base("Primero", "Realizar un programa que cree una lista enlazada con los nombres de los integrantes del curso y la permita imprimir hacía atrás y hacia adelante.") {
    }

    protected override void Execute() {
        var list = new LinkedList<string>();
        list.AddLast("Juan");
        list.AddLast("Pedro");
        list.AddLast("Maria");
        list.AddLast("Jose");
        
        Console.WriteLine("Hacia adelante");
        var node = list.First;
        while (node != null) {
            Console.WriteLine(node.Value);
            node = node.Next;
        }
        
        Console.WriteLine("");
        
        Console.WriteLine("Hacia atras:");
        Console.WriteLine("");
        node = list.Last;
        while (node != null) {
            Console.WriteLine(node.Value);
            node = node.Previous;
        }
    }
}