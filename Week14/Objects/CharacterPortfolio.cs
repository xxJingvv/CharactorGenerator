﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTOIONS: This is the main container for the application
 */


namespace Week14.Objects
{
    public class CharacterPortfolio
    {
        //Identity
        public Identity Identity { get; set; }
        //characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        //Skill List
        List<Skill> Skills;

        //constructor
        CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();

        }
    }
}
