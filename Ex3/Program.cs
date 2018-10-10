using System;

namespace Ex3.Classes {
    class Program {
        static void Main (string[] args) {
            Porta porta = new Porta ();
            float op = 5;

            Console.Clear ();
            while (op != 0) {
                Console.WriteLine ("1 = Abrir");
                Console.WriteLine ("2 = Fechar");
                op = float.Parse (Console.ReadLine ());

                switch (op) {
                    case 1:
                        {
                            porta.Abrir ();
                            break;
                        }
                    case 2:
                        {
                            porta.Fechar ();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Opção Inválida");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}