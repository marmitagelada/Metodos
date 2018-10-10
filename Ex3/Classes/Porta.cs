namespace Ex3.Classes {
    public class Porta {
        bool aberta = false;

        #region Métodos

        public void Abrir () {
            if (aberta == false) {
                aberta = true;
                System.Console.WriteLine ("A porta abriu");
            } else {
                System.Console.WriteLine ("Não precisa se esforçar pra nada");
            }
        }

        public void Fechar () {
            if (aberta == false) {
                System.Console.WriteLine ("A porta já está fechada");
            } else {
                aberta = false;
                System.Console.WriteLine ("A porta fechou");
            }
        }

        #endregion 
    }
}