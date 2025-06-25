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
Node? resultadoGet1 = linkedList.Get(0);