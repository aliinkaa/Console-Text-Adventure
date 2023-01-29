using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCode
{
    class Player
    {
        private Character selectedChar;
        private string name;
        private int failCount;
        private bool freshmenFail;
        private bool bartenderFail;
        private bool boothsFail;
        private bool beenToBar;
        private bool beenToDanceFloor; //means that player have already been to dance floor and returned from there to the bar once.
        private bool returnToBar;
        private bool freshmenConversed;
        private bool compGuyFail;
        private bool laurenceConversed;
        

        //private bool freshmenToBooths;
        //private bool laurenceToBooths;

        public Character getSelectedChar()
        {
            return selectedChar;
        }
       
        public bool BeenToDanceFloor
        {
            get
            {
                return beenToBar;
            }
            set
            {
                beenToDanceFloor = value;
            }
        }

        public Player(int charSelected)
        {
            selectedChar = new Character(charSelected);
            failCount = 0;
            freshmenFail = false;
            bartenderFail = false;
            boothsFail = false;
            beenToBar = false;
            returnToBar = false;
            freshmenConversed = false;
            compGuyFail = false;
            laurenceConversed = false;
            beenToDanceFloor = false;
            

            //freshmenToBooths = false;
            //laurenceToBooths = false;
        }


        public bool LaurenceConversed
        {
            get
            {
                return laurenceConversed;
            }
            set
            {
                laurenceConversed = value;
            }
        }

        public bool CompGuyFail
        { 
            get
            {
                return compGuyFail;
            }
            set
            {
                compGuyFail = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool BeenToBar
        {
            get
            {
                return beenToBar;
            }
            set
            {
                beenToBar = value;
            }
        }

        public int FailCount
        {
            get
            {
                return failCount;
            }
            set
            {
                failCount = value;
            }
        }

        public bool FreshmenFail
        {
            get
            {
                return freshmenFail;
            }
            set
            {
                freshmenFail = value;
            }
        }

        public bool BartenderFail
        {
            get
            {
                return bartenderFail;
            }
            set
            {
                bartenderFail = value;
            }
        }

        public bool BoothsFail
        {
            get
            {
                return boothsFail;
            }
            set
            {
                boothsFail = value;
            }
        }

        public bool ReturnToBar
        {
            get
            {
                return returnToBar;
            }
            set
            {
                returnToBar = value;
            }
        }

        public bool FreshmenConversed
        {
            get
            {
                return freshmenConversed;
            }
            set
            {
                freshmenConversed = value;
            }
        }

    }
}
