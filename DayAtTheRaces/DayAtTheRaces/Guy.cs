using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet; // An instance of Bet that has his bet
        public int Cash; // How much cash he has
        public RadioButton MyRadioButton; //My radioButton
        public Label MyLabel; // My Label
        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label on my 
            // radio button to show my cash ("Joe has 43 bucks")
        }
        public void CearBet()
        {
            //reset my bet so it's zero
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet and update my labels
        }
    }
}
