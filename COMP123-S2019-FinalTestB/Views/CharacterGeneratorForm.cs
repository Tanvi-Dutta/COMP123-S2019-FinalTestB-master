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
 * STUDENT NAME: Tanvi
 * STUDENT ID: 301044096
 * DESCRIPTION: This is the Character Generator  Form - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        //Creating string lists for first names and last names
        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();
        List<string> InventoryList = new List<string>();

        /// <summary>
        /// This method loads the content of firstNames and LastNames into their respective Lists
        /// </summary>
        public void LoadNames()
        {
            List<string> FirstNameList = File.ReadAllLines("C:\\Users\\tanvi\\Downloads\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FinalTestB\\Data\\firstNames.txt").ToList();
            List<string> LastNameList = File.ReadAllLines("C:\\Users\\tanvi\\Downloads\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FianlTestB\\Data\\lastNames.txt").ToList();

        }

        /// <summary>
        /// This method picks a random string from the lists and displays them into the respective label
        /// </summary>
        public void GenerateNames()
        {
            //creating an instance of class random
             Random rnd = new Random();
            //fetching a random string from First names
            string Fname = FirstNameList[rnd.Next(FirstNameList.Count)];
            //fetching a random string from Last Names
            string Lname = LastNameList[rnd.Next(LastNameList.Count)];
            //displaying the string in the labels
            FirstNameDataLabel.Text = Fname;
            LastNameDataLabel.Text = Lname;
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the form loading event for the CharacterGeneratorForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
        }


        /// <summary>
        /// This is the event handler for Generate Button's click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
         GenerateNames();
            FirstNameDataLabel.Text = Program.character.FirstName;
            LastNameDataLabel.Text = Program.character.LastName;
        }

        public void ability()
        {
            Random rnd = new Random();
            //generating rnadom numbers
            int Strength = rnd.Next(3, 18);
            int Dexterity = rnd.Next(3, 18);
            int Constitution = rnd.Next(3, 18);
            int Intelligence = rnd.Next(3, 18);
            int Wisdom = rnd.Next(3, 18);
            int Charisma = rnd.Next(3, 18);
            //displaying the random numbers into labels
            StrengthDataLabel.Text = Convert.ToString(Strength);
            DexterityDataLabel.Text = Convert.ToString(Dexterity);
            ConstitutionDataLabel.Text = Convert.ToString(Constitution);
            IntelligenceDataLabel.Text = Convert.ToString(Intelligence);
            WisdomDataLabel.Text = Convert.ToString(Wisdom);
            CharismaDataLabel.Text = Convert.ToString(Charisma);
        }

        public void LoadInventory()
        {
            List<string> FirstNameList = File.ReadAllLines("C:\\Users\\tanvi\\Downloads\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FinalTestB-master\\COMP123-S2019-FinalTestB\\Data\\inventory.txt").ToList();
        }
    }
}
