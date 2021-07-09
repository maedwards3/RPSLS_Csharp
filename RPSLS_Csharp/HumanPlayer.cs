using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Csharp
{
    public class HumanPlayer : Player
    {
        // HumanPlayer variables
        public string name;

        // constructor
        public HumanPlayer(string name, bool wins, int chosenGesture)
        {
            this.name = name;
            this.wins = wins;
            this.chosenGesture = chosenGesture;
        }

        // member methods
    }
}
