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

    /// <summary>
    /// Exibir os elementos da lista no terminal
    /// </summary>
    public void PrintList()
    {
        System.Console.WriteLine("[PRINTLIST] EXIBINDO ELEMENTOS DA LISTA");

        Node? node_aux = this.head;
        int lenght_aux = 0;

        while (node_aux is not null)
        {
            System.Console.WriteLine($"[{lenght_aux++}] : {node_aux.Value}");
            node_aux = node_aux.Next;
        }
        System.Console.WriteLine($"[PRINTLIST] TOTAL DE ELEMENTOS {this.lenght}");
    }

    /// <summary>
    /// Acrescentar elemento na última posição da lista
    /// </summary>
    /// <param name="value">Tipo numérico inteiro</param>
    /// <returns>Tipo booleano se execução concluída com sucesso</returns>
    public bool Append(int value)
    {
        System.Console.WriteLine($"[APPEND] ADICIONANDO ELEMENTO A LISTA [{this.lenght}] : {value}");
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
        System.Console.WriteLine($"[APPEND] TOTAL DE ELEMENTOS {this.lenght}");
        return true;
    }

    /// <summary>
    /// Remover o último elemento da lista
    /// </summary>
    /// <returns>Nodo removido da lista</returns>
    public Node? Pop()
    {
        Node? pre_node = this.head;
        Node? pop_node = null;

        if (this.head is null)
        {
            System.Console.WriteLine("[POP] LISTA VAZIA");
            return null;
        }
        else if (this.head.Next is null)
        {
            pop_node = this.head;
            this.head = null;
            this.tail = null;
        }
        else
        {
            while (pre_node?.Next is not null)
            {
                if (pre_node.Next.Next is null)
                {
                    pop_node = pre_node.Next;
                    this.tail = pre_node;
                    this.tail.Next = null;
                    break;
                }

                pre_node = pre_node.Next;
            }
        }

        this.lenght--;
        System.Console.WriteLine($"[POP] REMOVENDO ELEMENTO [{this.lenght}] : {pop_node?.Value}");
        return pop_node;
    }

    /// <summary>
    /// Adicionar elemento na primeira posição da lista
    /// </summary>
    /// <param name="value">Tipo numérico inteiro</param>
    /// <returns>Tipo booleano se execução concluída com sucesso</returns>
    public bool Prepend(int value)
    {
        Node new_node = new(value);
        new_node.Next = this.head;
        this.head = new_node;

        if (this.lenght == 0)
            this.tail = new_node;

        System.Console.WriteLine($"[PREPEND] ADICIONANDO ELEMENTO [0] : {value}");
        this.lenght++;
        return true;
    }

    /// <summary>
    /// Remover o primeiro elemento da lista
    /// </summary>
    /// <returns>Nodo removido da lista</returns>
    public Node? PopFirst()
    {
        if (this.lenght == 0)
        {
            System.Console.WriteLine("[POPFIRST] LISTA VAZIA");
            return null;
        }

        Node? popfirst_node = this.head;

        System.Console.WriteLine($"[POPFIRST] ELEMENTO REMOVIDO [0] : {popfirst_node.Value}");

        this.head = this.head.Next;
        popfirst_node.Next = null;
        this.lenght--;

        if (this.lenght == 0)
            this.tail = null;

        return popfirst_node;
    }

    /// <summary>
    /// Localizar elemento de acordo com índice informado pelo usuário
    /// </summary>
    /// <param name="index">Índice da posição do elemento buscado</param>
    /// <returns>Nodo de índice informado pelo usuário</returns>
    public Node? Get(int index)
    {
        if (!(index >= 0 && index < this.lenght))
        {
            System.Console.WriteLine("[GET] ÍNDICE INVÁLIDO");
            return null;
        }

        Node? node_aux = this.head;

        for (int i = 0; i < this.lenght; i++)
        {
            if (i == index)
                break;

            node_aux = node_aux.Next;
        }

        System.Console.WriteLine($"[GET] NODO ENCONTRADO [{index}] : {node_aux?.Value}");
        return node_aux;
    }

    /// <summary>
    /// Alterar o valor de elemento conforme índice informado pelo usuário
    /// </summary>
    /// <param name="index">Índice do elemento na lista</param>
    /// <param name="value">Valor para alteração do elemento na lista</param>
    /// <returns>Tipo booleano se ret</returns>
    public bool Set(int index, int value)
    {
        Node? node_result = Get(index);

        if (node_result is null)
        {
            System.Console.WriteLine($"[SET] ÍNDICE NÃO ENCONTRADO [{index}]");
            return false;
        }

        node_result.Value = value;
        System.Console.WriteLine($"[SET] ELEMENTO ADICIONADO [{index}] : {value}");
        return true;
    }

    // TODO: PROBLEMA NA LÓGICA
    public bool Insert(int index, int value)
    {
        Node? node_aux = Get(index);
        Node new_node = new(value);

        if (this.lenght == 0 && index == 0)
        {
            this.head = new_node;
            this.tail = new_node;
        }
        else if (node_aux is null)
        {
            System.Console.WriteLine($"[INSERT] ÍNDICE INVÁLIDO");
            return false;
        }
        else
        {
            new_node.Next = node_aux;
            node_aux.Next = new_node;
        }

        this.lenght++;
        System.Console.WriteLine($"[INSERT] ELEMENTO INSERIDO COM SUCESSO [{index} : {value}]");
        return true;
    }

    public Node? Remove(int index)
    {
        if (this.lenght == 0)
        {
            System.Console.WriteLine("[REMOVE] LISTA VAZIA");
            return null;
        }
        if (index < 0 || index >= this.lenght)
        {
            System.Console.WriteLine("[REMOVE] ÍNDICE INVÁLIDO");
            return null;
        }
        if (index == 0)
        {
            return PopFirst();
        }
        if (index == this.lenght-1)
        {
            return Pop();
        }

        Node? prev = Get(index-1);
        Node? temp = prev?.Next;

        prev.Next = temp.Next;
        temp.Next = null;

        System.Console.WriteLine($"[REMOVE] ELEMENTO REMOVIDO [{index}] : {temp.Value}");
        this.lenght--;
        return temp;
    }
 
    public bool Reverse()
    {
        if (this.lenght == 1)
        {
            return true;
        }

        Node? temp = this.head;
        this.head = this.tail;
        this.tail = temp;

        Node? prev = null;
        Node? next;

        for (var i = 0; i < this.lenght; i++)
        {
            next = temp?.Next;
            temp.Next = prev;
            prev = temp;
            temp = next;
        }

        return true;
    }
}

public class Node
{
    public Node() => System.Console.WriteLine("[CONSTRUCTOR] CONSTRUINDO NODO");

    public Node(int value)
    {
        this.Value = value;
        this.Next = null;
    }

    public int Value { get; set; }
    public Node? Next { get; set; }
}