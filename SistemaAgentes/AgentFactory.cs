using SistemaAgentes.Core.Implementations;
using SistemaAgentes.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgentes.App
{
    public class AgentFactory
    {

        public static IStrategy CreateAgent(string AgentType)
        {
            switch (AgentType)
            {
                case "A":
                    return new AgentA();
                case "B":
                    return new AgentB();
                case "C":
                    return new AgentC();
                default:
                    throw new ArgumentException("Invalid Agent type.");
            }
        }

    }
}
