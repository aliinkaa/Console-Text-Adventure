using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCode
{
    enum Skills {QuickHacking, LockPicking, BlendCrowd, Seduction, LieDetect, SVision, Taijitsu, Stealth, Intimidation}
    class Character
    {
        //more properties will be added.
        private Skills[] SkillSet;
        
        public Character(int charSelected)
        {
            switch (charSelected)
            {
                case 1:
                    {
                        //Mr. Robot
                        SkillSet = new Skills[] {Skills.QuickHacking, Skills.LockPicking, Skills.BlendCrowd};
                    }
                    break; //cases for other characters will go here.
                case 2: 
                    {
                        //Alice Wakefield
                        SkillSet = new Skills[] {Skills.Seduction, Skills.LieDetect, Skills.SVision};
                    }
                    break;
                case 3:
                    {
                        //The Bride
                        SkillSet = new Skills[] {Skills.Taijitsu, Skills.Stealth, Skills.Intimidation};
                    }
                    break;
            }
            
        }

        public bool containsSkill(Skills skill)
        {
            for (int i = 0; i < SkillSet.Length; i++)
            {
                if (SkillSet[i] == skill)
                    return true;
            }

            return false;
        }

    }
}
