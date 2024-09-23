using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StateString
    {
        public string ToStateString(State state)
        {
            switch (state)
            {
                case State.Finished:
                    return "Afgerond";
                case State.BeingPrepared:
                    return "Wordt voorbereid";
                case State.NotStarted:
                    return "Niet begonnen";
                case State.Served:
                    return "Geserveerd";
                case State.Unknown:
                    return "Onbekend";
                default:
                    return state.ToString();
            }
        }
    }
}
