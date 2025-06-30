public class Queue
{
    public Queue(int value)
    {
        Node new_node = new(value);
        this.First = new_node;
        this.Last = new_node;
        this.Lenght = 1;
    }

    public int Lenght { get; set; }
    public Node? First { get; set; }
    public Node? Last { get; set; }

    public void PrintQueue()
    {
        System.Console.WriteLine("[PRINT QUEUE] EXIBINDO LISTA DE ELEMENTOS");
        Node? temp = this.First;
        int num = 0;

        if (this.Lenght == 0)
        {
            System.Console.WriteLine("[PRINT QUEUE] LISTA VAZIA");
            return;
        }

        while (temp is not null)
        {
            System.Console.WriteLine($"[PRINT QUEUE] ELEMENTO [{num}] : {temp.Value}");

            num++;
            temp = temp.Next;
        }
    }

    public bool Enqueue(int value)
    {
        Node new_node = new(value);

        if (this.Lenght == 0)
        {
            this.First = new_node;
            this.Last = new_node;
        }
        else
        {
            this.Last.Next = new_node;
            this.Last = new_node;
        }

        this.Lenght++;
        return true;
    }

    public Node? Dequeue()
    {
        if (this.Lenght == 0)
        {
            System.Console.WriteLine("[DEQUEUE] LISTA VAZIA");
            return null;
        }
        else if (this.Lenght == 1)
        {
            this.First = null;
            this.Last = null;
        }

        var temp = this.First;
        this.First = this.First.Next;
        temp.Next = null;
        this.Lenght--;
        return temp;
    }
}