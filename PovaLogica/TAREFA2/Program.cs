using System.Globalization;
using TAREFA2;


var data = File.ReadAllLines("../../../../../mapa.csv", System.Text.Encoding.UTF8);
Mapa locais = new Mapa();
var lista = new List<string>();
var aux = "";

foreach (var line in data)
{
    locais = line;
    lista.Add(locais);
}

void BubbleSort(List<string> lista)
{
    for (int i = 1; i < lista.Count; i++)
    {
        for (int j = 0; j < lista.Count - 1; j++)
        {
            if (lista[j] != lista[0] && j <= lista.Count)
            {
                int valor1 = Convert.ToInt32(lista[j].Split(',')[1]);
                int valor2 = Convert.ToInt32(lista[j + 1].Split(',')[1]);
                
                if (valor1 < valor2)
                {
                    aux = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = aux;
                }
            }    
        }
    }
}

BubbleSort(lista);

foreach (var i in lista)
{
    Console.WriteLine(i);
}
Console.WriteLine("---------------------------------");
Console.WriteLine("Arquivo salvo na pasta do projeto: mapa-ordenado-bubblesort.csv");
//Usar a função do c#
//Array.Sort();

File.WriteAllLines(@"../../../../../mapa-ordenado-bubblesort.csv", lista, System.Text.Encoding.UTF8);
Console.Read();