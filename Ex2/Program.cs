using System;

namespace Ex2.Classes {
    class Program {
        static void Main (string[] args) {
            Garrafa grf = new Garrafa ();
            float op = 5;

            Console.Clear ();
            do {

                Console.WriteLine ("Menu de Opções: ");
                Console.WriteLine ("1 = Encher");
                Console.WriteLine ("2 = Esvaziar");
                Console.WriteLine ("3 = Exibir Quantidade Atual");

                op = float.Parse (Console.ReadLine ());

                switch (op) {
                    case 1:
                        {
                            System.Console.WriteLine ("Digite a quantidade em 'ml' que deseja colocar na garrafa:");
                            float qtd = float.Parse (Console.ReadLine ());

                            grf.Encher (qtd);
                            grf.ExibirQt ();
                            break;
                        }

                    case 2:
                        {
                            System.Console.WriteLine ("Digite a quantidade em 'ml' que deseja retirar na garrafa:");
                            float qtd = float.Parse (Console.ReadLine ());

                            grf.Esvaziar (qtd);
                            grf.ExibirQt ();
                            break;
                        }

                    case 3:
                        {
                            grf.ExibirQt ();
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            } while (op != 0);
        }
    }
}