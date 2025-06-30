public class Stack
{
    public Stack(int value)
    {
        Node new_node = new(value);
        this.Top = new_node;
        this.Height = 1;
    }

    public Node? Top { get; set; }
    public int Height { get; set; }

    public void PrintStack()
    {
        System.Console.WriteLine("[PRINTLIST] EXIBINDO ELEMENTOS DA LISTA");
        
        if (this.Height == 0)
        {
            System.Console.WriteLine("[PRINTSTACK] STACK VAZIA");
        }

        Node temp = this.Top;
        int index = 0;

        while (temp is not null)
        {
            System.Console.WriteLine($"[PRINTSTACK] ELEMENTO [{index}] : {temp.Value}");
            index++;
            temp = temp.Next;
        }
    }

    public bool Push(int value)
    {
        Node new_node = new(value);

        if (this.Top is null)
        {
            this.Top = new_node;    
        }
        else
        {
            new_node.Next = this.Top;
            this.Top = new_node;    
        }
        
        this.Height++;
        return true;
    }

    public Node? Pop()
    {
        if (this.Height == 0)
        {
            System.Console.WriteLine("[POP STACK] LISTA VAZIA");
            return null;
        }

        Node temp = this.Top;

        if (this.Height == 1)
        {
            this.Top = null;
        }
        else
        {
            this.Top = this.Top.Next;
            temp.Next = null;
        }

        this.Height--;
        return temp;
    }
}