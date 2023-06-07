using SistemaAgentes.Core.Interfaces;


namespace SistemaAgentes.Core.Implementations
{
    public class AgentB : IStrategy
    {
        public double GetMedia(List<double> numberList)
        {
            double reverseSum = 0;

            foreach (double value in numberList)
            {
                reverseSum += 1 / value;
            }

            double meanHarmonica = numberList.Count / reverseSum;
            return meanHarmonica;
        }

        public string GetStaircase(int n)
        {
            string line = "";
            int espaces = 0;
            for (int i = n; i > 0; i--)
            {
                
                int steps = i;
                line += new string(' ', espaces) + new string('#', steps) + (i != 1 ? Environment.NewLine : "") ;
                espaces += 1;

            }
            return line;
        }
    }
}
