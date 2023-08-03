using System.Globalization;
using TAREFA1;


var data = File.ReadAllLines("../../../../../mapa.csv", System.Text.Encoding.UTF8);
Mapa locais = new Mapa();
var lista = new List<string>();

foreach (var line in data)
{
    locais = line;
    if (line != data[0])
        locais.Populacao = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N0}", Convert.ToInt32(locais.Populacao));

    lista.Add(locais);
}

File.WriteAllLines(@"../../../../../mapa-alterado.csv", lista, System.Text.Encoding.UTF8);

Console.WriteLine("Documento mapa.csv alterado com sucesso!");
Console.WriteLine("Documento mapa-alterado.csv gerado na pasta do projeto.");
Console.WriteLine("Pressione qualquer tecla para sair");
Console.Read();