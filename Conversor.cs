namespace POO_Static
{
    public static class Conversor
    {
        //atributos
        private static float cotacaoDolar = 5.07f;
        private static float cotacaoEuro = 6.16f;

        //metodos
        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorDol){
            return valorDol * cotacaoDolar;
        }

        public static float RealParaEuro(float valorRSEuro){
            return valorRSEuro / cotacaoEuro;
        }

        public static float EuroParaReal(float valorEuro){
            return valorEuro * cotacaoEuro;
        }


    }
}