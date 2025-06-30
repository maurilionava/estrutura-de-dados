public class SelectionSort
{
    public int[] Sort(int[] lista)
    {
        int temp = 0;
 
        for (var i = 0; i < lista.Length-1; i++)
        {
            int min_index = i;
            for (var j = i+1; j < lista.Length; j++)
            {
                if (lista[j] < lista[min_index])
                {
                    min_index = j;
                }
            }

            if (i != min_index)
            {
                temp = lista[i];
                lista[i] = lista[min_index];
                lista[min_index] = temp;
            }
        }

        return lista;
    }
}