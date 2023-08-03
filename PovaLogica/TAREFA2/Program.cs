int temp;
int[] lista = new int[10];

Random numeroAleatorio = new Random();

for (int i = 0; i < 10; i++)
{
    lista[i] = numeroAleatorio.Next(1, 100);
    Console.Write(lista[i] + " ");
};
Console.WriteLine("\n----------------------------");
void BubbleSort(int[] valor)
{
    for (int i = 1; i < valor.Length; i++)
    {
        for (int j = 0; j < valor.Length - 1; j++)
        {
            if (valor[j] > valor[j + 1])
            {
                temp = valor[j];
                valor[j] = valor[j + 1];
                valor[j + 1] = temp;
            }
        }
    }

    foreach (int i in valor)
    {
        Console.Write(i + " ");
    }
}

BubbleSort(lista);

Console.Read();