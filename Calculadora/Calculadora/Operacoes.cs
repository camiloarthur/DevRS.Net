
namespace Calculadora
{
    public static class Operacoes
    {
        public static long Somar(long numero1, long numero2)
        {
            return numero1 + numero2;
        }

        public static long Subtrair(long minuendo, long subtraendo)
        {
            return minuendo - subtraendo; 
        }

        public static long Multiplicar(long multiplicando, long multiplicador)
        {
            return multiplicando * multiplicador;
        }

        public static double Dividir(double dividendo, double divisor)
        {
            try
            {
                return dividendo / divisor;
            }
            catch (System.DivideByZeroException)
            {
                throw new System.DivideByZeroException("O divisor não pode ser zero!");
            }
        }
    }
}
