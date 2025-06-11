﻿using DesafioFundamentos.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");

Estacionamento estacionamento = new Estacionamento();
estacionamento.precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
estacionamento.precoPorHora = Convert.ToDecimal(Console.ReadLine());

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    
    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
       
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para Continuar");
    Console.ReadLine();

}

Console.WriteLine("O Programa encerrou");