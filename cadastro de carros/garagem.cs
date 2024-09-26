using System;
using System.Collections.Generic;

class Program
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }

    static List<Carro> carros = new List<Carro>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("1. Cadastrar Carro");
            Console.WriteLine("2. Listar Carros");
            Console.WriteLine("3. Atualizar Carro");
            Console.WriteLine("4. Excluir Carro");  
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            int v = int.Parse(s: Console.ReadLine());
            opcao = v;

            if (opcao == 1)
            {
                CadastrarCarro();
            }
            else if (opcao == 2)
            {
                ListarCarros();
            }
            else if (opcao == 3)
            {
                AtualizarCarro();
            }
            else if (opcao == 4)
            {
                ExcluirCarro(); 
            }

        } while (opcao != 0);
    }

    static void CadastrarCarro()
    {
        Carro carro = new Carro();

        Console.Write("Informe a Marca: ");
        carro.Marca = Console.ReadLine();

        Console.Write("Informe o Modelo: ");
        carro.Modelo = Console.ReadLine();

        Console.Write("Informe o Ano: ");
        carro.Ano = int.Parse(Console.ReadLine());

        Console.Write("Informe a Cor: ");
        carro.Cor = Console.ReadLine();

        carros.Add(carro);
        Console.WriteLine("Carro cadastrado com sucesso!");
    }

    static void ListarCarros()
    {
        Console.WriteLine("Lista de Carros:");
        if (carros.Count == 0)
        {
            Console.WriteLine("Nenhum carro cadastrado.");
            return;
        }

        for (int i = 0; i < carros.Count; i++)
        {
            var carro = carros[i];
            Console.WriteLine($"{i + 1}. Marca: {carro.Marca}, Modelo: {carro.Modelo}, Ano: {carro.Ano}, Cor: {carro.Cor}");
        }
    }

    static void AtualizarCarro()
    {
        ListarCarros();

        Console.Write("Informe o número do carro que deseja atualizar: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice < 0 || indice >= carros.Count)
        {
            Console.WriteLine("Carro inválido.");
            return;
        }

        Carro carro = carros[indice];

        Console.Write("Informe a nova Marca (deixe em branco para manter): ");
        string novaMarca = Console.ReadLine();
        if (!string.IsNullOrEmpty(novaMarca))
        {
            carro.Marca = novaMarca;
        }

        Console.Write("Informe o novo Modelo (deixe em branco para manter): ");
        string novoModelo = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoModelo))
        {
            carro.Modelo = novoModelo;
        }

        Console.Write("Informe o novo Ano (deixe em branco para manter): ");
        string novoAno = Console.ReadLine();
        if (int.TryParse(novoAno, out int anoValido))
        {
            carro.Ano = anoValido;
        }

        Console.Write("Informe a nova Cor (deixe em branco para manter): ");
        string novaCor = Console.ReadLine();
        if (!string.IsNullOrEmpty(novaCor))
        {
            carro.Cor = novaCor;
        }

        Console.WriteLine("Carro atualizado com sucesso!");
    }

    static void ExcluirCarro()
    {
        ListarCarros();

        Console.Write("Informe o número do carro que deseja excluir: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        if (indice < 0 || indice >= carros.Count)
        {
            Console.WriteLine("Carro inválido.");
            return;
        }

        carros.RemoveAt(indice);
        Console.WriteLine("Carro excluído com sucesso!");
    }
}
