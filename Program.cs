using System;
using JogoRPG.Src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Guerreiro Tonhao = new Guerreiro("Tonhão", 23, "Guerreiro");
        Magos Angelica = new Magos("Angelica", 20, "Mago");
        Ninja BruceLee = new Ninja("BruceLee", 30, "Ninja");
        Inimigo inimigo = new Inimigo("Inimigo", 99, "Vilão");

        Console.WriteLine(" Pressione enter para iniciar");
        string acao1 = Console.ReadLine();
        Console.WriteLine(Tonhao.Ataque());
        Console.WriteLine();
        Console.WriteLine(" Pressione enter");
        string acao2 = Console.ReadLine();
        Console.WriteLine(Angelica.Ataque(4));
        Console.WriteLine();
        Console.WriteLine(" Pressione enter");
        string acao3 = Console.ReadLine();
        Console.WriteLine(BruceLee.Ataque());
        Console.WriteLine();
        Console.WriteLine(" Pressione enter");
        string acao4 = Console.ReadLine();
        Console.WriteLine(inimigo.Ataque());
        Console.WriteLine();
        Console.WriteLine(" Pressione enter");
        string acao5 = Console.ReadLine();
         Console.WriteLine(Tonhao.Defesa());
        Console.WriteLine();
        Console.WriteLine(" Pressione enter");
        string acao6 = Console.ReadLine();
        Console.WriteLine(Angelica.Ataque(7));
        Console.WriteLine();
        Console.WriteLine(" O inimigo foi derrotado");
        Console.WriteLine();
        Console.WriteLine(" Você venceu!!! ");
    }
}

