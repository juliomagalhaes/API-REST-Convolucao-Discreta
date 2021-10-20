using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMatematica
{
    public static class Convolucao
    {
        public static int[] Convoluir(int[] arg_vetor1, int[] arg_vetor2)
        {
            //Tamanhos
            int vetor1_tamanho = arg_vetor1.Length,
                vetor2_tamanho = arg_vetor2.Length;

            //Tamanho da convolução
            int tamanho_convolucao = vetor1_tamanho + vetor2_tamanho - 1;

            var resultado_convolucao = new int[tamanho_convolucao];

            for (int i = 0; i < tamanho_convolucao; i++)
            {
                for (int j = 0; j < vetor2_tamanho; j++)
                {
                    //Multiplicando e acumulando caso não esteja fora do range do vetor
                    if (i - j >= 0 && i - j < vetor1_tamanho) resultado_convolucao[i] += arg_vetor1[i - j] * arg_vetor2[j];
                }
            }

            return resultado_convolucao;
        }

    }
}
