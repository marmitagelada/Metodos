namespace Ex1.Classes
{
    public class Calculadora
    {
        #region Métodos

        /// <summary>
        /// Efetuando a soma de 2 valores
        /// </summary>
        /// <param name="valor1">Informa o valor 1 </param>
        /// <param name="valor2">Informa o valor 2 </param>
        /// <returns></returns>Retorna a soma de 2 valores
        
        public double Somar(double valor1, double valor2){
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2){
            return valor1 - valor2;
        }

        public double Mult(double valor1, double valor2){
            return valor1 * valor2;
        }

        public double Div(double valor1, double valor2){
            return valor1 / valor2;
        }

        #endregion
    }
}