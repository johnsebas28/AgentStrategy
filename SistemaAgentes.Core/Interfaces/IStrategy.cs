using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgentes.Core.Interfaces
{
    public interface IStrategy
    {
        public double GetMedia(List<double> numberList);
        public string GetStaircase(int n);
    }
}
