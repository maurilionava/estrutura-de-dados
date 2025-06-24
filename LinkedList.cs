public class LinkedList
{
    public LinkedList() => System.Console.WriteLine("Construindo LinkedList");

    public LinkedList(int value)
    {
        System.Console.WriteLine($"Inicializando LinkedList com valor {value}");
        Node new_node = new(value);
        this.head = new_node;
        this.tail = new_node;
        this.lenght = 1;
    }

    public Node? head;
    public Node? tail;
    public int lenght = 0;

    public void PrintList()
    {
        System.Console.WriteLine("### Exibindo valores da LinkedList ###");

        Node node_aux = this.head;
        int lenght_aux = 0;

        while (node_aux is not null)
        {
            System.Console.WriteLine($"[{lenght_aux++}] : {node_aux.Value}");
            node_aux = node_aux.Next;
        }
        System.Console.WriteLine($"Total de elementos {this.lenght}");
    }

    public bool Append(int value)
    {
        System.Console.WriteLine($"### Executando Append do valor {value} ###");
        Node new_node = new(value);

        if (this.head is null)
        {
            this.head = new_node;
            this.tail = new_node;
        }
        else
        {
            this.tail.Next = new_node;
            this.tail = new_node;
        }

        this.lenght++;
        System.Console.WriteLine($"Total de elementos {this.lenght}");
        return true;
    }

    public bool Pop()
    {
        
    }
}

public class Node
{
    public Node() => System.Console.WriteLine("Construindo Nodo");

    public Node(int value)
    {
        this.Value = value;
        this.Next = null;
    }

    public int Value { get; set; }
    public Node Next { get; set; }
}