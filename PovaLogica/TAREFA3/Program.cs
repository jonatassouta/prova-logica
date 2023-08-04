using Refit;
using TAREFA3;

var file = File.ReadAllLines("../../../../../CEPs.csv");
var listaCeps = new List<string>();
string txtLinhaArquivo = "";

foreach (var line in file)
{
    txtLinhaArquivo = line;
    var txtLinhaSeparadaCep = line.Split(';')[0];
    var cep = txtLinhaSeparadaCep.Replace("-", "").Replace(" ", "");

    if (line != file[0])
    {
        txtLinhaArquivo = await ResponseApi(cep);
    }

    listaCeps.Add(txtLinhaArquivo);
    Console.WriteLine(txtLinhaArquivo);
}

static async Task<string> ResponseApi(string cep)
{
    try
    {
        var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");

        Console.WriteLine("\nCep informado: " + cep + "\n");

        if (cep.Length != 8)
            return $"{cep};CEP Invalido";

        var endereco = await cepClient.GetAddressAsync(cep);

        string txt = $"{cep};{endereco.Logradouro};{endereco.Complemento};{endereco.Bairro};{endereco.Localidade};{endereco.UF};{endereco.Unidade};{endereco.Ibge};{endereco.Gia}";

        return txt;

    }
    catch (Exception e)
    {
        Console.WriteLine("Erro na consulta: " + e.Message);
        return "Bad Request";
    }
}

File.WriteAllLines(@"../../../../../CEPs-preenchidos.csv", listaCeps, System.Text.Encoding.UTF8);
Console.WriteLine("\n\nDocumento CEPs-preenchidos.csv criado.");

Console.Read();