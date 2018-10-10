using System;

namespace Ex4.Classes {
    class Program {
        static void Main (string[] args) {
            Triangulo tgl = new Triangulo ();
            Console.WriteLine ("Informe a medida do lado A:");
            tgl.ladoA = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe a medida do lado B:");
            tgl.ladoB = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe a medida do lado C:");
            tgl.ladoC = float.Parse (Console.ReadLine ());

            if (tgl.Valido())
            {
                System.Console.WriteLine("Seu triângulo é: " + tgl.TipoTriangulo());
            }
            else {
                System.Console.WriteLine("O seu triângulo não é válido");
            }
        }
    }
}