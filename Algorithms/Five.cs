using App26092022.Utils;

namespace App26092022.Algorithms; 

public class Five : Algorithm {

    public Five() : base("Cinco", 
        "Escribir un programa que pida al usuario una palabra y muestre por pantalla si es un palíndromo."
        ) {
    }

    protected override void Execute() {
        var text = InputUtils.GetText("Ingrese una palabra");
        var trimed = text.ToLower().Trim();
        var isPalindrome = IsPalindrome(trimed);
         
         Console.WriteLine($"La palabra '{text}' " + (isPalindrome ? "es" : "no es") + " un palíndromo");
    }
    
    private bool IsPalindrome(string word) {
        var linkedList = new LinkedList<char>();
        foreach (var letter in word) {
            linkedList.AddLast(letter);
        }
        
        var firstNode = linkedList.First;
        var lastNode = linkedList.Last;
        
        while (firstNode != lastNode) {
            if (firstNode == null || lastNode == null || firstNode.Value != lastNode.Value) {
                return false;
            }
            
            firstNode = firstNode.Next;
            lastNode = lastNode.Previous;
        }
        
        
        return true;
    }
    
}