using RFAB_builder.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFAB_builder
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public bool InfoFormIsShows = false;
        public bool CreateCharacterFormShows = false;

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.Text = "RFABuilder v." + Assembly.GetEntryAssembly().GetName().Version.ToString();
            this.BackgroundImage = Properties.Resources.MainMenuBackgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (!InfoFormIsShows)
            {
                InfoFormIsShows=true;
                InfoForm infoForm = new InfoForm(this);
                infoForm.Show();
            }
        }

        private void CreateNewCharButton_Click(object sender, EventArgs e)
        {
            if (!CreateCharacterFormShows)
            {
                CreateCharacterFormShows = true;
                CreateCharacterForm createCharacterForm = new CreateCharacterForm(this);
                createCharacterForm.Show();
            }
        }
    }
}
