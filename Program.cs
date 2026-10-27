
using System;
using System.Collections.Generic;

class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Eu sou um animal.");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animais = new List<Animal>();

        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Rex";
        cachorro.Idade = 3;

        Gato gato = new Gato();
        gato.Nome = "Mimi";
        gato.Idade = 2;

        animais.Add(cachorro);
        animais.Add(gato);

        Console.WriteLine("=== SISTEMA DE ANIMAIS ===");

        foreach (Animal animal in animais)
        {
            Console.WriteLine("Animal: " + animal.Nome);
            Console.WriteLine("Idade: " + animal.Idade + " anos");
            Console.Write("Som: ");
            animal.EmitirSom();
            Console.WriteLine();
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}


