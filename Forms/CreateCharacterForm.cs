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

        private void CreateCharacterForm_Load(object sender, EventArgs e)
        {
            Logger.Info("Show create character form");
        }

        private void CreateCharacterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.CreateCharacterFormShows = false;
            Logger.Info("Close create character form");
        }
    }
}
