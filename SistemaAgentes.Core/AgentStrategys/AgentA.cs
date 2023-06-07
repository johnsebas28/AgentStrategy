using SistemaAgentes.Core.Interfaces;


namespace SistemaAgentes.Core.Implementations
{
    public class AgentA : IStrategy
    {
        public double GetMedia(List<double> numberList)
        {

            double acum = 0;
            foreach (var number in numberList)
            {
                acum += number;
            }
            return acum / numberList.Count;

        }

        public string GetStaircase(int n)
        {
            string line = "";
            for (int i = 1; i <= n; i++)
            {
                int espacios = n - i;
                int escalones = i;
                line  += new string(' ', espacios) + new string('#', escalones) + Environment.NewLine;
             
            }
            return line;
        }
    }
}
