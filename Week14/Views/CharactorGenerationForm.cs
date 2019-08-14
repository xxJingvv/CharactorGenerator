using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME:Xiaojing Xu
 * STUDENT ID:300993994
 * DESCRIPTOIONS: This is the main process of the Charactor Generation form
 */

namespace Week14.Views
{
    public partial class CharactorGenerationForm : Week14.Views.MasterForm
    {
        public CharactorGenerationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTapControl.SelectedIndex != 0)
            {
                MainTapControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTapControl.SelectedIndex < MainTapControl.TabPages.Count - 1)
            {
                MainTapControl.SelectedIndex++;
            }
        }

        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();
        List<string> SkillList = new List<string>();

        private void LoadNames()
        {
            string firstNameLocation = @"..\..\Data\firstNames.txt";
            using (StreamReader inputStream = new StreamReader(
                       File.Open(firstNameLocation, FileMode.Open)))
            {
                FirstNameList = File.ReadAllLines(firstNameLocation).ToList();
            }
            string lastNameLocation = @"..\..\Data\lastNames.txt";
            using (StreamReader inputStream = new StreamReader(
                       File.Open(lastNameLocation, FileMode.Open)))
            {
                FirstNameList = File.ReadAllLines(lastNameLocation).ToList();
            }
        }
        private void GenerateNames()
        {
            int FirstNameRand = new Random().Next(0, FirstNameList.Count);
            int LastNameRand = new Random().Next(0, FirstNameList.Count);
            FirstNameDataLabel.Text = FirstNameList[FirstNameRand];
            LastNameDataLabel.Text = LastNameList[LastNameRand];
        }

        private void CharactorGenerationForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            LoadSkills();
            GenerateNames();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            Program.identity.FirstName = FirstNameDataLabel.Text;
            Program.identity.LastName = LastNameDataLabel.Text;
            FirstNameDataLabel.Text = Program.character.Identity.FirstName;
            LastNameDataLabel.Text = Program.character.Identity.LastName;
        }

        private void GenerateAbility()
        {
            Program.character.Strength = new Random().Next(0, 15).ToString();
            StrengthDataLabel.Text = Program.character.Strength;
            Program.character.Dexterity = new Random().Next(0, 15).ToString();
            DexterityDataLabel.Text = Program.character.Dexterity;
            Program.character.Endurance = new Random().Next(0, 15).ToString();
            EnduranceDataLabel.Text = Program.character.Endurance;
            Program.character.Intellect = new Random().Next(0, 15).ToString();
            IntellectDataLabel.Text = Program.character.Intellect;
            Program.character.Education = new Random().Next(0, 15).ToString();
            EducationDataLabel.Text = Program.character.Education;
            Program.character.SocialStanding = new Random().Next(0, 15).ToString();
            SocialStandingDataLabel.Text = Program.character.SocialStanding;
        }

        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {
            GenerateAbility();
        }

        private void LoadSkills()
        {
            string skillsLocation = @"..\..\Data\skills.txt";
            using (StreamReader inputStream = new StreamReader(
                       File.Open(skillsLocation, FileMode.Open)))
            {
                SkillList = File.ReadAllLines(skillsLocation).ToList();
            }

        }
        private void GenerateSkills()
        {
            int SkillRand1 = new Random().Next(0, SkillList.Count);
            int SkillRand2 = new Random().Next(0, SkillList.Count);
            int SkillRand3 = new Random().Next(0, SkillList.Count);
            int SkillRand4 = new Random().Next(0, SkillList.Count);

            SkillDataLabel1.Text = SkillList[SkillRand1];
            SkillDataLabel2.Text = SkillList[SkillRand2];
            SkillDataLabel3.Text = SkillList[SkillRand3];
            SkillDataLabel4.Text = SkillList[SkillRand4];
        }
        private void GenerateSkillButton_Click(object sender, EventArgs e)
        {
            GenerateSkills();
        }
    }
}
