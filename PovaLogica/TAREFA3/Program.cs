var file = File.ReadAllLines("../../../../../CEPs.csv");

foreach (var line in file)
{
    var txt = line.Split(';')[0];
    var ceps = txt.Replace("-", "").Replace(" ", "");
    Console.WriteLine(ceps);
    
}

Console.Read();