namespace Ex4.Classes {
    public class Triangulo {
        public float ladoA, ladoB, ladoC;
        #region Métodos

        public bool Valido () {
            if ((ladoA < ladoB + ladoC) &&
                (ladoB < ladoA + ladoC) &&
                (ladoC < ladoA + ladoB)) {
                return true;
            } else {
                return false;
            }
        }

        public string TipoTriangulo () {
            if (ladoA == ladoB && ladoA == ladoC) {
                return "equilátero";
            } else if (ladoB != ladoC && ladoA != ladoC) {
                return "escaleno";
            } else {
                return "isósceles";
            }
        }

        #endregion
    }
}