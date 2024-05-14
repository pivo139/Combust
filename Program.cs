// See https://aka.ms/new-console-template for more information

using System.Net.Mail;

double MediaCombustivel, alcool, gasolina;
String op = "s";

while(op.Equals("s")){
Console.WriteLine("Insira o valor do alcool: ");
alcool = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valo da gasolina: ");
gasolina = double.Parse(Console.ReadLine());

MediaCombustivel = alcool/gasolina;

if(MediaCombustivel <= 0.7){
    Console.WriteLine("Vale a pena colocar alcool!");
}
else if(MediaCombustivel >= 0.7){
    Console.WriteLine("Vale a pena colocar gasolina!");
}

Console.Write("Deseja fazer uma nova operacao (s/n)? ");
op = Console.ReadLine();
}

Console.WriteLine("Obrigado, volte sempre!");
Console.Write("Posto Ipiranga");