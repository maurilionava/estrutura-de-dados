LinkedList linkedList = new(1);
bool resultadoPrepend = linkedList.Prepend(0);
bool resultadoAppend = linkedList.Append(2);
// 0 1 2
linkedList.PrintList();
Node? resultadoPop = linkedList.Pop();
// 0 1
linkedList.PrintList();
Node? resultadoPopfirst = linkedList.PopFirst();
// 1
linkedList.PrintList();
Node? resultadoGet0 = linkedList.Get(100);
bool resultadoAppend1 = linkedList.Append(2);
Node? resultadoGet1 = linkedList.Get(0);
Node? resultadoGet2 = linkedList.Get(1);
Node? resultadoGet3 = linkedList.Get(2);

bool resultadoAppend2 = linkedList.Append(5);

bool resultadoSet0 = linkedList.Set(1, 100);
bool resultadoSet1 = linkedList.Set(2000, 100);
linkedList.PrintList();

// bool resultadoInsert = linkedList.Insert(0,9);
Node? resultadoRemove = linkedList.Remove(0);

linkedList.PrintList();