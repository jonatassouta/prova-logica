using Refit;
using TAREFA3;

var file = File.ReadAllLines("../../../../../CEPs.csv");

foreach (var line in file)
{
    var txt = line.Split(';')[0];
    var ceps = txt.Replace("-", "").Replace(" ", "");
    Console.WriteLine(ceps);

    if(line != file[0])
    { 
        if (ceps.Length == 8)
        {
            await ResponseApi(ceps);
        }
    }
}

    

static async Task ResponseApi(string cep)
{
    try
    {
        var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");

        Console.WriteLine("\nCep informado " + cep);

        var endereco = await cepClient.GetAddressAsync(cep);

        Console.WriteLine($"\nLogradouro: {endereco.Logradouro} \nBairro: {endereco.Bairro} \nCidade: {endereco.Localidade}");
    }
    catch (Exception e)
    {

        Console.WriteLine("Erro na consulta: " + e.Message);
    }
}

Console.Read();