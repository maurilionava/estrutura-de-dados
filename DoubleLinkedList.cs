public class DoubleLinkedList
{
    public DoubleLinkedList(int value)
    {
        DLLNode new_node = new(value);
        this.Head = new_node;
        this.Tail = new_node;
        this.Lenght = 1;
    }

    public int Lenght { get; set; }
    public DLLNode? Head { get; set; }
    public DLLNode? Tail { get; set; }

    public void PrintList()
    {
        System.Console.WriteLine("[PRINTLIST DLL] EXIBINDO ELEMENTOS DA LISTA");
        DLLNode? temp = this.Head;
        int index = 0;

        while (temp is not null)
        {
            System.Console.WriteLine($"[PRINTLIST DLL] ELEMENTO [{index}]: {temp.Value}");
            index++;
            temp = temp.Next;
        }
    }

    public bool Append(int value)
    {
        DLLNode new_node = new(value);

        if (this.Head is null)
        {
            this.Head = new_node;
        }
        else
        {
            this.Tail.Next = new_node;
            new_node.Previous = this.Tail;
        }

        this.Tail = new_node;
        this.Lenght++;
        return true;
    }

    // TODO: ARRUMAR PROBLEMA NULLREFERENCEEXCEPTION LINHA 62
    public DLLNode Pop()
    {
        if (this.Head is null)
        {
            System.Console.WriteLine("[POP DLL] LISTA VAZIA");
            return null;
        }
        else
        {
            System.Console.WriteLine($"[POP DLL] REMOVENDO ELEMENTO [{this.Lenght - 1}] : {this.Tail.Value}");
            DLLNode? pop_node = this.Tail;
            // DLLNode? prev = this.Tail?.Previous;
            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;
            // prev.Next = null;
            pop_node.Previous = null;
            this.Lenght--;

            if (this.Lenght == 0)
            {
                this.Head = null;
                this.Tail = null;
            }

            return pop_node;
        }
    }

    public bool Prepend(int value)
    {
        DLLNode new_node = new(value);

        if (this.Head is null)
        {
            this.Head = new_node;
            this.Tail = new_node;
        }
        else
        {
            new_node.Next = this.Head;
            this.Head.Previous = new_node;
            this.Head = new_node;
        }

        this.Lenght++;
        System.Console.WriteLine($"[PREPEND DLL] ADICIONADO ELEMENTO [0] : {value}");
        return true;
    }

    public DLLNode? PopFirst()
    {
        if (this.Head is null)
        {
            System.Console.WriteLine("[POPFIRST DLL] LISTA VAZIA");
            return null;
        }

        DLLNode popfirst_node = this.Head;

        if (this.Lenght == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            popfirst_node.Next = null;
        }

        this.Lenght--;
        return popfirst_node;
    }

    public DLLNode? Get(int index)
    {
        return null;
    }
}

public class DLLNode
{
    public DLLNode(int value)
    {
        this.Value = value;
        this.Next = null;
        this.Previous = null;
    }

    public int Value { get; set; }
    public DLLNode? Next { get; set; }
    public DLLNode? Previous { get; set; }
}
