using System;
class Aula08
{
    static void Main()
    {
        //int v1, v2, soma;
        string nome;
        int idade;
        string endereco;
        string profi;

        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine();

        //Console.Write("Digite um valor: ");
        //v1 = int.Parse(Console.ReadLine());

        // Console.Write("Digite outro valor: ");
        //v2 = int.Parse(Console.ReadLine());

        //soma = v1 + v2;

        // Console.WriteLine("Nome: {0}",nome);
        // Console.WriteLine("A soma dos valores {0} e {1} é de {2}",v1, v2, soma);

        Console.WriteLine("Preencha com seus dados o FORMULÁRIO a seguir: ");

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Informe seu endereço: ");
        endereco = Console.ReadLine();

        Console.Write("Informe sua profissão:");
        profi = Console.ReadLine();

        Console.WriteLine("\n\nNome........: {0,5}", nome);
        Console.WriteLine("Idade.....: {0,5}", idade);
        Console.WriteLine("Profissão....: {0,5}", profi);
        Console.WriteLine("Endereço.....: {0,5}", endereco);
    }
}
