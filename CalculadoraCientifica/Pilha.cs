using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraCientifica
{
    class Pilha
    {
        private int[] vet; // vetor para armazenar os elementos da pilha
        private int topo; // indica a posição do topo

        public Pilha(int tamanho) // CONSTRUTOR
        {
            vet = new int[tamanho];
            topo = 0;
        }

        public void Empilhar(int item)
        {
            vet[topo] = item;
            topo++;
        }

        public int Desempilhar()
        {
            topo--;
            return vet[topo];
        }

        public bool Cheia()
        {
            return topo == vet.Length;
        }

        public bool Vazia()
        {
            return topo == 0;
        }
    }
}
