#region LinkedList
// LinkedList linkedList = new(1);
// bool resultadoPrepend = linkedList.Prepend(0);
// bool resultadoAppend = linkedList.Append(2);
// // 0 1 2
// linkedList.PrintList();
// Node? resultadoPop = linkedList.Pop();
// // 0 1
// linkedList.PrintList();
// Node? resultadoPopfirst = linkedList.PopFirst();
// // 1
// linkedList.PrintList();
// Node? resultadoGet0 = linkedList.Get(100);
// bool resultadoAppend1 = linkedList.Append(2);
// Node? resultadoGet1 = linkedList.Get(0);
// Node? resultadoGet2 = linkedList.Get(1);
// Node? resultadoGet3 = linkedList.Get(2);

// bool resultadoAppend2 = linkedList.Append(5);

// bool resultadoSet0 = linkedList.Set(1, 100);
// bool resultadoSet1 = linkedList.Set(2000, 100);
// linkedList.PrintList();

// // bool resultadoInsert = linkedList.Insert(0,9);
// Node? resultadoRemove = linkedList.Remove(0);

// linkedList.Append(6);
// linkedList.Append(7);
// linkedList.Append(8);
// linkedList.Append(9);

// linkedList.PrintList();

// var resultadoReverse = linkedList.Reverse();

// linkedList.PrintList();
#endregion

#region DoubleLinkedList
// DoubleLinkedList dll = new(1);
// dll.Append(2);
// dll.Append(3);
// dll.PrintList();
// dll.Pop();
// dll.Pop();
// dll.PrintList();
// dll.Prepend(0);
// dll.PrintList();
// dll.PopFirst();
// dll.PopFirst();
// dll.PopFirst();
// dll.PrintList();
#endregion

#region Stack
// Stack stack = new(3);
// stack.Push(2);
// stack.Push(1);
// stack.Push(0);

// stack.PrintStack();

// stack.Pop();
// stack.Pop();
// stack.Pop();

// stack.PrintStack();
#endregion

#region Queue
// Queue queue = new(0);
// queue.Enqueue(1);
// queue.Enqueue(2);
// queue.Enqueue(3);
// queue.PrintQueue();

// queue.Dequeue();
// queue.Dequeue();
// queue.Dequeue();
// queue.Dequeue();
// queue.PrintQueue();
#endregion

#region BasicSort
var lista = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

// BubbleSort bubbleSort = new();
// var listaOrdenadaBubbleSort = bubbleSort.Sort(lista);
// PrintList(listaOrdenadaBubbleSort);

// SelectionSort selectionSort = new();
// var listaOrdenadaSelectionSort = selectionSort.Sort(lista);
// PrintList(listaOrdenadaSelectionSort);
#endregion

void PrintList(int[] lista) {
    System.Console.WriteLine("[MAIN PRINTLIST] EXIBINDO LISTA");

    foreach (var numero in lista)
    {
        System.Console.Write($"{numero}, ");
    }
    System.Console.WriteLine();    
}