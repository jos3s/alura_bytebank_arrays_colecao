using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Util
{
    public class ListaContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public ListaContasCorrentes(int tamInicial = 5)
        {
            _itens = new ContaCorrente[tamInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionado item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i] == item)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i+1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void VerificarCapacidade(int novoTamanho)
        {
            if (_itens.Length < novoTamanho)
            {
                Console.WriteLine("Aumentando capacidade da lista.");
                ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

                for (int i = 0; i < _itens.Length; i++)
                {
                    novoArray[i] = _itens[i];
                }
                _itens = novoArray;
            }
        }
    
        public void Listar()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                    Console.WriteLine($"Indice[{i}] - Conta: {_itens[i].Conta}, N. da Agência: {_itens[i].Numero_agencia}");
            }
        }
    }
}
