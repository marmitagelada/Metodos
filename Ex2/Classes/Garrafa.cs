namespace Ex2.Classes
{
    public class Garrafa
    {
        #region 

        private float conteudo = 1000;

        #endregion

        #region Métodos

        public void Encher(float qtd){
            conteudo+=qtd;
        }

        public void Esvaziar(float qtd){
            conteudo-=qtd;
            if (qtd < 0)
            {
                System.Console.WriteLine("Opção inválida");
            }
        }

        public void ExibirQt(){
            System.Console.WriteLine($"A quantidade atual é {conteudo}");
        }

        #endregion
    }
}