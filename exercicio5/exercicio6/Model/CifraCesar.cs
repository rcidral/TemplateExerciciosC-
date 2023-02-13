using System;

namespace NamespaceCifraCesar
{
    class CifraCesar
    {
        public static string Criptografia(string mensagem, int valorConstante)
        {
            mensagem = mensagem.ToLower();
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int tamanhoAlfabeto = alfabeto.Length;
            char[] novaMensagem = new char[mensagem.Length];
    
            for (int i = 0; i < mensagem.Length; i++)
            {
                int posicao = Array.IndexOf(alfabeto, mensagem[i]);
                if (posicao == -1)
                {
                    novaMensagem[i] = mensagem[i];
                }
                else
                {
                    int novaPosicao = (posicao + valorConstante) % tamanhoAlfabeto;
                    novaMensagem[i] = alfabeto[novaPosicao];
                }
            }
    
            return new string(novaMensagem);
        }
    }
}

