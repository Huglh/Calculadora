using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(100); // Criando uma pilha com tamanho máximo de 100 valores

            while (true)
            {
                Console.WriteLine("Digite um número inteiro ou um operador matemático (+, -, *, /):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number)) 
                {
                    if (!pilha.Cheia())
                    {
                        pilha.Empilhar(number);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Pilha cheia!");
                    }
                }
                else if (input == "+" || input == "-" || input == "*" || input == "/") //Nesta parte do código, a condição else if verifica se a entrada do usuário é um operador matemático válido (+, -, *, /).
                {
                    if (!pilha.Vazia())
                    {
                        int operand2 = pilha.Desempilhar();
                        int operand1 = pilha.Desempilhar();

                        int result = 0;

                        if (input == "+")
                        {
                            result = operand1 + operand2;
                        }
                        else if (input == "-")
                        {
                            result = operand1 - operand2;
                        }
                        else if (input == "*")
                        {
                            result = operand1 * operand2;
                        }
                        else if (input == "/")
                        {
                            result = operand1 / operand2;
                        }

                        pilha.Empilhar(result);
                        Console.WriteLine("Resultado: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Pilha vazia!");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }
            }
        }
    }

}
