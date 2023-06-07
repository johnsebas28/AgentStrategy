using SistemaAgentes.Core.Interfaces;

namespace SistemaAgentes.Core.Implementations
{
    public class AgentC : IStrategy
    {
        public double GetMedia(List<double> numberList)
        {
            int totalData = numberList.Count;
            numberList.Sort();

            if (totalData % 2 == 0) // Cantidad de datos par
            {
                int idx1 = totalData / 2 - 1;
                int idx2 = totalData / 2;

                double n1 = numberList[idx1];
                double n2 = numberList[idx2];

                return (n1 + n2) / 2;
            }
            else // Cantidad de datos impar
            {
                int idx =  totalData / 2;
                return numberList[idx];
            }
        }

        public string GetStaircase(int n)
        {
            string line = "";
            int spaces = n;
            int steps = n;
            for (int i = 1; i <= (n * 2) - 1; i++)
            {

                if (i < n)
                {
                    spaces--;

                }
                else
                {
                    spaces++;

                }
                if (i == n)
                {
                    spaces = 0;
                }
                line += new string(' ', spaces) + new string('#', steps) + new string(' ', spaces) + (i < (n * 2) - 1 ? Environment.NewLine : "");
                if (i < n)
                {

                    steps += 2;
                }
                else
                {

                    steps -= 2;
                }

            }
            return line;

        }
    }
}
