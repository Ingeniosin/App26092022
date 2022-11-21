using App26092022.Utils;

namespace App26092022.Algorithms; 

public class Two : Algorithm {


    public Two() : base("Segundo", "En el ejercicio anterior, se requiere hacer uso de los métodos Remove (node), Remove(T), RemoveFirst(), RemoveLast(), Clear(), después de la ejecución de cada método imprimir los elementos de la lista.") {
    }

    protected override void Execute() {
        var list = new LinkedList<string>();
        list.AddLast("Juan");
        list.AddLast("Pedro");
        list.AddLast("Maria");
        list.AddLast("Jose");
        list.AddLast("Luis");
        
        print(list);
        
        var whileLoop = true;
        while (whileLoop) {
            InputUtils.SelectFunction(new Dictionary<string, Action>{
                {
                    "Eliminar primer elemento [remove(node)]", () => {
                        var node = list.First;
                        list.Remove(node);
                        print(list);
                    }
                },
                {
                    "Eliminar un elemento", () => {
                        var target = InputUtils.GetText("Ingrese el elemento a eliminar");
                        if (list.Remove(target)) {
                            print(list);
                        } else {
                            Console.WriteLine("No se encontró el elemento");
                        }
                    }
                },
                {
                    "Eliminar primer elemento [RemoveFirst]", () => {
                        list.RemoveFirst();
                        print(list);
                    }
                },
                {
                    "Eliminar último elemento", () => {
                        list.RemoveLast();
                        print(list);
                    }
                },
                {
                    "Limpiar lista", () => {
                        list.Clear();
                        print(list);
                    }
                },
                {
                    "Salir", () => {
                        whileLoop = false;
                    }
                }
            });
        }
        
       


    }

    private static void print(LinkedList<string> list) {
        Console.WriteLine("Hacia adelante");
        var node = list.First;
        while(node != null) {
            Console.WriteLine(node.Value);
            node = node.Next;
        }

        Console.WriteLine("");

        Console.WriteLine("Hacia atras:");
        Console.WriteLine("");
        node = list.Last;
        while(node != null) {
            Console.WriteLine(node.Value);
            node = node.Previous;
        }
    }
}