namespace Aula2
{
    public class Primo
    {
        public bool NumeroPrimo(long num = 1)
        {
            return false;
        }
        public bool NumeroPrimo(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}