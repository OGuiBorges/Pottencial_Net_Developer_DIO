using ExemplosFundamentos.Common.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 62;
arrayInteiros[2] = 44;
arrayInteiros[3] = 21;

foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine(listaString[i]);
}

foreach (string s in listaString)
{
    Console.WriteLine(s);
}

































// using System;

// namespace ExemplosFundamentos.NET6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Ola");
//         }
//     }
// }

// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Dividir(30,10);
// calc.Multiplicar(2, 10);
// calc.Subtrair(30, 15);
// calc.Potenciar(3, 3);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

//Environment.Exit(0);

// int quantidadeEstoque = 10;

// int quantidadeCompra = 11;

// if(quantidadeEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Não tem");
// }

// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual.ToString("HH:mm"));

// string s = "15-0";
// //Cast - Casting


// int c = 0;
// c += 1;
// c -= 1;
// c *= 1;

// int a = Convert.ToInt32("5");
// int b = int.Parse("5");
// double.Parse("10.5");


// int.TryParse(s, out a);

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine(quantidade);
// quantidade = 10;
// Console.WriteLine(quantidade);
// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;



// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da var quantidade: " + quantidade);
// Console.WriteLine("Valor da var altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da var preco: " + preco);
// Console.WriteLine("Valor da var condicao: " + condicao);

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Guilherme";
pessoa1.Idade = 21;
pessoa1.Apresentar();*/
