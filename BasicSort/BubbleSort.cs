public class BubbleSort
{
    public int[] Sort(int[] lista)
    {
        for (var i = lista.Length-1; i >= 0; i--)
        {
            for (var j = 0; j < i; j++)
            {
                int temp = 0;

                if (lista[j] > lista[j + 1])
                {
                    temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }

        return lista;
    }
}