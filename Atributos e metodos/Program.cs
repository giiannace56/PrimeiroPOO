using System;

namespace Atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento objeto

            Personagem jogador1 = new Personagem();
            jogador1.nome "bruno donadeimuito ";
            jogador1.idade = 18;
            jogador1.armadura = "tankerstitanium";
            jogador1.IA = "Talento Do Campeão";




            Personagem jogador2 = new Personagem();
            jogador2.nome = "lucas glauberth";
            jogador2.idade = 12;
            jogador2.armadura = "bbs|escudo";

            Console.Clear();
            Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.IA} || Jogador 2 IA: {jogador2.IA}");

            //COMECE A LUTA

            int vidaDoJogador2 = jogador2.Defender(jogador1.Atacar2());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O Jogador foi eliminado ");
            }else{
                Console.WriteLine($"Jogador 2 após o ataque ficou com {jogador2.vida}");
            }
        }
    }
}
