using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dice_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string SouN;
            float pontosA;
            float pontosVS;
            float aposta;
            int diceA1;
            int diceA2;
            int diceA3;
            int diceVS1;
            int diceVS2;
            int diceVS3;
            int timer = 0;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ? THE DICE GAME ? by Ricardo Azzi Silva");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("\tVocê sabe jogar esse jogo?:");
        volta1:
            Console.Write("\t");
            SouN = Console.ReadLine();
            if (SouN == "S" || SouN == "Sim" || SouN == "sim" || SouN == "s")
            {
            }
            else if (SouN == "Naum" || SouN == "naum" || SouN == "Não" || SouN == "Nao" || SouN == "n" || SouN == "n" || SouN == "No" || SouN == "não")
            {
                Console.Clear();
                Console.WriteLine(" ? THE DICE GAME ? by Ricardo Azzi Silva");
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("\tOBJETIVO: ganhar todos os pontos do adversario.");
                Console.WriteLine();
                Console.WriteLine("\tREGRAS: Você joga TRÊS dado sobre uma mesa:");
                Console.WriteLine("\t 1 - caso o cair dos dados dois número iguais e um diferente,");
                Console.WriteLine("\t     o diferente será o número dos seus pontos;");
                Console.WriteLine("\t 2 - caso os dados caiam na seqüência 1 - 2 - 3, você perde o dobro");
                Console.WriteLine("\t     da sua aposta;");
                Console.WriteLine("\t 3 - caso os dados caiam na seqüência 4 - 5 - 6, você ganha o dobro");
                Console.WriteLine("\t     da sua aposta;");
                Console.WriteLine("\t 4 - há possibilidade do dado cair da mesa, com isso você perde o");
                Console.WriteLine("\t     turno;");
                Console.WriteLine("\t 5 - se todos os dados cairem números diferentes você não faz nenhum");
                Console.WriteLine("\t     ponto, porém tem a chance de jogar novamente. Caso caia 3 vezes");
                Console.WriteLine("\t     seguidas números diferentes no dado, sua pontuação é 0;");
                Console.WriteLine("\t 6 - se todos os dados cairem números iguais, você ganha o");
                Console.WriteLine("\t     triplo do apostado e o oponente perde o triplo.");
                Console.WriteLine();
                Console.WriteLine("\tAPOSTA: Cada jogador começa com um número maior ou igual a 50 pontos,");
                Console.WriteLine("\tem cada turno você decide um tanto de pontos a apostar, o máximo da");
                Console.WriteLine("\taposta são 30 pontos");
                Console.WriteLine();
                Console.WriteLine("\tDigite qualquer tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\tDigite \"Sim\" ou \"Não\"");
                goto volta1;
            }
            Console.Clear();
            Console.WriteLine(" ? THE DICE GAME ? by Ricardo Azzi Silva");
            Console.WriteLine("");
            Console.WriteLine();
            Console.Write("\tLoading");
            Console.Write(" . ");
            System.Threading.Thread.Sleep(750);
            Console.Write(". ");
            System.Threading.Thread.Sleep(750);
            Console.WriteLine(". ");
            Console.WriteLine("\tOk");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(" ? THE DICE GAME ? by Ricardo Azzi Silva");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("\tDeseja jogar com quantos pontos?");
        volta2:
            Console.Write("\t");
            pontosA = int.Parse(Console.ReadLine());
            if (pontosA < 50)
            {
                Console.WriteLine("\tVocê deve jogar com 50 pontos ou mais!");
                goto volta2;
            }
            pontosVS = pontosA;
            Console.WriteLine("\tQuanto deseja apostar nesse turno?");
        volta3:
            Console.Write("\t");
            aposta = int.Parse(Console.ReadLine());
            if (aposta > 30)
            {
                Console.WriteLine("\tVocê deve apostar 30 pontos ou menos!");
                goto volta3;
            }
            Console.Clear();
            Console.WriteLine(" ? THE DICE GAME ? by Ricardo Azzi Silva");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("\tSeus pontos = " + pontosA + "\t\tAdversario = " + pontosVS);
            Console.WriteLine("\tDidite um número de 100 a 700:");
            volts:
            Console.Write("\t");
            timer = int.Parse(Console.ReadLine());
            if (timer > 700 || timer < 100)
            {
                Console.WriteLine("\tEntre 100 e 700!");
                goto volts;
            }
            System.Threading.Thread.Sleep(timer);
            Console.WriteLine("\tPressione qualquer tecla para jogar o 1º dado;");
            Console.Write("\t");
            Console.ReadKey();
            Console.WriteLine();
            Random U = new Random();
            diceA1 = U.Next(13);
            timer = timer - 50 * 2;
            System.Threading.Thread.Sleep(timer);
            Console.WriteLine("\tPressione qualquer tecla para jogar o 2º dado;");
            Console.Write("\t");
            Console.ReadKey();
            Console.WriteLine();

            Random V = new Random();
            diceA2 = V.Next(13);
            timer = (timer - 100) / 2 + 50;
            System.Threading.Thread.Sleep(timer);
            Console.WriteLine("\tPressione qualquer tecla para jogar o 3º dado.");
            Console.Write("\t");
            Console.ReadKey();
            Console.WriteLine();

            Random W = new Random();
            diceA3 = W.Next(13);
            if (diceA1 == 1 || diceA1 == 2 || diceA1 == 3 || diceA1 == 4 || diceA1 == 5 || diceA1 == 6)
            {
                Console.WriteLine("\tDado 1: " + diceA1);
            }
            else if (diceA1 == 7 || diceA1 == 8 || diceA1 == 9 || diceA1 == 10 || diceA1 == 11 || diceA1 == 12)
            {
                diceA1 = diceA1 - 6;
                Console.WriteLine("\tDado 1: " + diceA1);
            }
            else if (diceA1 == 13)
            {
                Console.WriteLine("\tO dado caiu da mesa!");
            }



            if (diceA2 == 1 || diceA2 == 2 || diceA2 == 3 || diceA2 == 4 || diceA2 == 5 || diceA2 == 6)
            {
                Console.WriteLine("\tDado 2: " + diceA2);
            }
            else if (diceA2 == 7 || diceA2 == 8 || diceA2 == 9 || diceA2 == 10 || diceA2 == 11 || diceA2 == 12)
            {
                diceA2 = diceA2 - 6;
                Console.WriteLine("\tDado 2: " + diceA2);
            }
            else if (diceA2 == 13)
            {
                Console.WriteLine("\tO dado caiu da mesa!");
            }



            if (diceA3 == 1 || diceA3 == 2 || diceA3 == 3 || diceA3 == 4 || diceA3 == 5 || diceA3 == 6)
            {
                Console.WriteLine("\tDado 3: " + diceA3);
            }
            else if (diceA3 == 7 || diceA3 == 8 || diceA3 == 9 || diceA3 == 10 || diceA3 == 11 || diceA3 == 12)
            {
                diceA3 = diceA3 - 6;
                Console.WriteLine("\tDado 3: " + diceA3);
            }
            else if (diceA3 == 13)
            {
                Console.WriteLine("\tO dado caiu da mesa!");
            }
            if (diceA1 == 13 || diceA2 == 13 || diceA3 == 13)
            {
                Console.WriteLine("Você perdeu esse turno!");
            }
            else if (diceA1 == diceA2 && diceA1 != diceA3)
            {
                Console.WriteLine("Você fez " + diceA3 + " pontos");
            }
        }
    }
}
