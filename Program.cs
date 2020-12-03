using System;

namespace atividadeCelular.classe
{
    class Program
    {
        static void Main(string[] args)
        {
            celular celular = new celular();

            Console.WriteLine("Está ligado? s/n");
            string escolha = Console.ReadLine();

            if(escolha == "s") {
                celular.ligado = true;
            } else if(escolha == "n") {
                celular.ligado = false;
            }

            do {
                Console.WriteLine("Digite a cor: ");
                celular.cor = Console.ReadLine();

                Console.WriteLine("Digite o modelo: ");
                celular.modelo = Console.ReadLine();

                Console.WriteLine("Digite o tamanho: ");
                celular.tamanho = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o telefone: ");
                celular.telefone = Console.ReadLine();

                celular.FazerLigacao(celular.telefone);
                celular.EnviarMensagem(celular.telefone);
            } while(celular.ligado == false);
        }
    }
}
