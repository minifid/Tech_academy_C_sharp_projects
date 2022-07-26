using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Blackjack.Card;

namespace Blackjack
{
    public class BlackJackRules
    {
        //sets the value for each of the cards for blackjack
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1//sets ace as its lower value handling for value of 11 is done in GetAllPossibleHandValues()
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //creates a list of all possible totals the hand can have
            int aceCount = Hand.Count(x => x.face == Face.Ace);//gets number of aces in hand
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.face]);//creates the value of the hand using the value of 1 for all aces
            result[0] = value;
            //if there are any aces this will go through and create another value inside results for each possible combination
            if (result.Length == 1) return result;
            for (int i = 0; i < result.Length; i++)//i equals the number of aces that equal 11 in the hand (adds 10 per ace) starts with only 1 ace equaling 11 then 2 aces then 3...
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }



        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand)
;
            int value = possibleValues.Where(x => x<22).Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
