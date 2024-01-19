using celular.Models;

Iphone iphone1 = new Iphone("1", "1", "1", 2);

Nokia nokia1 = new Nokia("2", "2", "2", 3);

string app = "github";

nokia1.InstalarAplicativo(app);
nokia1.Ligar();
nokia1.ReceberLigacao();
iphone1.InstalarAplicativo(app);
iphone1.Ligar();
iphone1.ReceberLigacao();
Console.WriteLine($"teste de nokia numero {nokia1.Numero}imei {nokia1.Imei}memoria {nokia1.Memoria} modelo {nokia1.Modelo}");
Console.WriteLine($"teste de iphone numero {iphone1.Numero}imei {iphone1.Imei}memoria {iphone1.Memoria} modelo {iphone1.Modelo}");
