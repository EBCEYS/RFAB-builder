using RFAB_builder;
using RFAB_builder.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFAB_builder.Forms
{
    public partial class CreateCharacterForm : Form
    {
        public CreateCharacterForm(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            mainMenu = mainMenuForm;
        }

        private readonly MainMenuForm mainMenu;

        public Characters YourChar { get; set; }

        public void UpdateElements()
        {
            RaceLabel.Text = "Раса: " + YourChar.Race.Name;
            NameLabel.Text = "Имя: " + YourChar.Name;
            StoneLabel.Text = "Камень: " + YourChar.Stone?.Name ?? "камень не выбран";
        }

        private void CreateCharacterForm_Load(object sender, EventArgs e)
        {
            Logger.Info("Show create character form");
            Text = "Меню выбора персонажа";
        }

        private void CreateCharacterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.CreateCharacterFormShows = false;
            Logger.Info("Close create character form");
        }

        public void ВыборРасыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseRaceForm chooseRaceForm = new ChooseRaceForm(this);
            chooseRaceForm.Show();
        }

        private void ВыборКамняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseStoneForm chooseStoneForm = new ChooseStoneForm(this);
            chooseStoneForm.Show();
        }
    }
}
