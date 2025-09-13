namespace Tyuiu.PozdeevaEA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numvers)
        {
            var total = 0;
            for (var i = 0; i < numvers.Length; i++)
            {
                total = total + numvers[i];
            }
            return total;
        }
        public static object SubstractionArray(int[] numvers)
        {
            var total = 0;
            int index = 0;

            while (index < numvers.Length) 
            {
                total = total - numvers[index];
                    index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] numvers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numvers[index];
                index++;
            }
            while (index < numvers.Length);

            return total;
        }
    }
}
