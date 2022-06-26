using System.ComponentModel;
using System.Text.RegularExpressions;
/*Projeto simples Calculadora C#
  Curso c# fundamentos Balta.io


  uso de classes, uso de herança
  metodos e atributos
*/
//calculadora de soma,sublitação,multiplicaçao,divisao,

//imports
using System;

//classe principal

public class Operaçoes
{
    public double Soma(double a, double b)
    {
        return a + b;
    }
    public double Sub(double a, double b)
    {
        return a - b;
    }
    public double Div(double a, double b)
    {
        return a / b;
    }
    public double Mul(double a, double b)
    {
        return a * b;
    }
    public void exitt()
    {
        System.Console.WriteLine("O programa esta sendo encerrado...");
    }


}



class Program : Operaçoes
{


    //metodo main
    static void Main(string[] args)
    {
        Operaçoes ope = new Operaçoes();
        int escolha = 1;
        while (escolha != 0)
        {
            Console.WriteLine("Programa para calcular.");
            System.Console.WriteLine("escollha 1 : Soma");
            System.Console.WriteLine("escollha 2 : Multiplicação");
            System.Console.WriteLine("escollha 3 : Sublitação");
            System.Console.WriteLine("escollha 4 : divisão");
            System.Console.WriteLine("escollha 0 : Sair");

            string linha = Console.ReadLine();
            escolha = int.Parse(linha);
            double a, b;

            switch (escolha)
            {
                case 0:
                    ope.exitt();
                    escolha = 0;
                    break;

                case 1:
                    System.Console.WriteLine("Voçe escolheu operação Soma:");
                    System.Console.WriteLine("Digite o  primeiro numero: ");
                    linha = Console.ReadLine();
                    a = double.Parse(linha);

                    System.Console.WriteLine("Digite o Segundo numero: ");
                    linha = Console.ReadLine();
                    b = double.Parse(linha);

                    Console.WriteLine(ope.Soma(a, b));
                    break;

                case 2:
                    System.Console.WriteLine("Voçe escolheu operação Soma:");
                    System.Console.WriteLine("Digite o  primeiro numero: ");
                    linha = Console.ReadLine();
                    a = double.Parse(linha);

                    System.Console.WriteLine("Digite o Segundo numero: ");
                    linha = Console.ReadLine();
                    b = double.Parse(linha);

                    Console.WriteLine(ope.Mul(a, b));
                    break;

                case 3:
                    System.Console.WriteLine("Voçe escolheu operação Soma:");
                    System.Console.WriteLine("Digite o  primeiro numero: ");
                    linha = Console.ReadLine();
                    a = double.Parse(linha);

                    System.Console.WriteLine("Digite o Segundo numero: ");
                    linha = Console.ReadLine();
                    b = double.Parse(linha);

                    Console.WriteLine(ope.Sub(a, b));
                    break;

                case 4:
                    System.Console.WriteLine("Voçe escolheu operação Soma:");
                    System.Console.WriteLine("Digite o  primeiro numero: ");
                    linha = Console.ReadLine();
                    a = double.Parse(linha);

                    System.Console.WriteLine("Digite o Segundo numero: ");
                    linha = Console.ReadLine();
                    b = double.Parse(linha);

                    Console.WriteLine(ope.Div(a, b));
                    break;
                default:
                    System.Console.WriteLine("nao foi identificado a oprçao:");
                    ope.exitt();
                    break;
            }
        }
    }
}