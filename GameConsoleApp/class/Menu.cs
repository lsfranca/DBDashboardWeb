using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsoleApp
{
    static class Menu
    {       

        public static void menuPrincipal()
        {
            int opcao=0;
            bool sair = false;
            Console.WriteLine("Bem Vindo!\n1- Novo Jogo\n2- Carrega Jogo\n3 - Gerenciar gravações\n4 - Sair");

            do
            {
                try
                {
                    opcao = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }


                switch (opcao)
                {
                    case 1:
                        novoJogo();
                        break;
                    case 2:
                        carregaJogo();
                        break;
                    case 3:
                        gravacoes();
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            } while (!sair);
            Console.WriteLine("Até logo!");
        }

        private static void gravacoes()
        {
            throw new NotImplementedException();
        }

        private static void carregaJogo()
        {
            throw new NotImplementedException();
        }

        private static void novoJogo()
        {
            int f, h, i, r, a, pdf; string historia, nome; Bag mochila = new Bag();
            int pts = 15;

            try
            {
                Console.WriteLine("Qual será seu nome? ");
                nome = Console.ReadLine();

                Console.WriteLine("Qual sua história? ");
                historia = Console.ReadLine();

                Console.WriteLine("Qual a sua força? (Valores permitidos: de 1 a 5) ");
                f = Int32.Parse(Console.ReadLine());
                pts -= f;

                Console.WriteLine("Qual a sua habilidade? (Valores permitidos: de 1 a 5) ");
                h = Int32.Parse(Console.ReadLine());
                pts -= h;

                Console.WriteLine("Qual a sua inteligência? (Valores permitidos: de 1 a 5) ");
                i = Int32.Parse(Console.ReadLine());
                pts -= i;

                Console.WriteLine("Qual a sua resistência? (Valores permitidos: de 1 a 5) ");
                r = Int32.Parse(Console.ReadLine());
                pts -= r;

                Console.WriteLine("Qual a sua armadura? (Valores permitidos: de 1 a 5) ");
                a = Int32.Parse(Console.ReadLine());
                pts -= a;

                Console.WriteLine("Qual o seu poder de fogo? (Valores permitidos: de 1 a 5) ");
                pdf = Int32.Parse(Console.ReadLine());
                pts -= pts;

                FichaJogador ficha = new FichaJogador(f, h, i, r, a, pdf, nome, historia, mochila);
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
