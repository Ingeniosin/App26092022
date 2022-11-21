using App26092022.Utils;

namespace App26092022.Algorithms; 

public class Three : Algorithm {

    public Three() : base("Tercero", 
        "Realizar un programa que permita convertir todos los elementos alfabéticos de una lista lineal sencilla que se encuentren en minúsculas a mayúsculas.") {
    }

    protected override void Execute() {
        var list = new LinkedList<char>();
        var input = InputUtils.GetText("Ingrese una cadena de texto");
        foreach (var c in input) {
            list.AddLast(c);
        }
        
        var node = list.First;
        while (node != null) {
            if (char.IsLower(node.Value)) {
                node.Value = char.ToUpper(node.Value);
            }
            node = node.Next;
        }
        
        var output = "";
        var firstNode = list.First;
        while (firstNode != null) {
            output += firstNode.Value;
            firstNode = firstNode.Next;
        }
        
        Console.WriteLine(output);
        
        
    }
}