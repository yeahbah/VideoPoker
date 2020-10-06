﻿using System.Collections.Generic;
using Yeahbah.Poker;
using Yeahbah.Poker.HandEvaluator;

namespace Poker.Games.VideoPoker
{
    public interface IVideoPoker
    {
        Card[] Hand { get; }        

        IList<PaySchedule> PaySchedule { get; set; }

        IDeck Deck { get; set; }

        GameVars GameVars {get; set;}

        void NewGame();
        void SelectUnitSize(decimal unitSize);
        void SelectBetSize(int betSize);
        void DepositMoney(decimal depositAmount);
        HandEvaluationResult Deal();

        VideoPokerResult Draw(int[] heldCardsIndeces);

        VideoPokerResult Draw(Card[] cards, int[] heldCardsIndeces);
    }
}
