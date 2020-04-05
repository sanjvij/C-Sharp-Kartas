﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingKata
{
    public class BowlingKataGame
    {
        public int ActiveFrameNumber { get; private set; } = 1;

        public int PinsDown { get; private set; } = 0;

        public int Attempts { get; private set; } = 0;

        public int BonusBalls { get; private set; } = 0;

        public void RollBal(int pinsDown)
        {
            Attempts++;
            PinsDown += pinsDown;

            if (PinsDown == 10)
            {
                if (Attempts == 2)
                    BonusBalls++;
                else
                    BonusBalls += 2;
            }

            if (PinsDown == 10 || Attempts == 2)
            {
                ActiveFrameNumber++;
                Attempts = 0;
            }
        }



        public int GetActiveFrameNumber()
        {
            return ActiveFrameNumber;
        }

        public int GetRemainingBonusBalls()
        {
            return BonusBalls;
        }

        public int GetScores()
        {
            return PinsDown;
        }
    }
}
