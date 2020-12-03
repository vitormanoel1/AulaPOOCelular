using System;
namespace atividadeCelular.classe
{
    public class celular
    {
            public string cor;
            public string modelo;
            public int tamanho;
            public bool ligado;

            public string telefone;
            public void Ligar(bool ligado) {
                ligado = true;
            }
            public void Desligar(bool ligado) {
                ligado = false;
            }
            public void FazerLigacao(string telefone) {
                Console.WriteLine($"Ligando para {telefone} ...");
            }
            public void EnviarMensagem(string telefone) {
                telefone = Console.ReadLine();
                Console.WriteLine($"Enviar mensagem para {telefone}");
        }
    }
}