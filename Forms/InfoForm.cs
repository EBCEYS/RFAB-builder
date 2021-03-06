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
    public partial class InfoForm : Form
    {
        private readonly MainMenuForm mainMenuForm;

        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenuForm;
            mainMenuForm.InfoFormIsShows = true;
            Logger.Info("Shows info form");
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            this.Text = "Справка";
            this.BackgroundImage = Properties.Resources.MainMenuBackgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.ForeColor = Color.Black;
            textBox1.Text =  $@"RFABulder программа для легкого и удобного создания{Environment.NewLine}своих билдов в Requiem For A Balance {Program.GameVersion}.{Environment.NewLine}Спасибо Sw1ft за RFABuilder в google docs.{Environment.NewLine}Автор: EBCEY.{Environment.NewLine}О возникших ошибках и пожеланиях можно написать мне в дискорд.{Environment.NewLine}При ошибках отправляйте логи{Environment.NewLine}{Logger.Path}";
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenuForm.InfoFormIsShows = false;
            Logger.Info("Close info form");
        }

        /// <summary>
        /// Дискод RFAB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://discord.gg/4yqdafW");
        }
        /// <summary>
        /// Сайт RFAB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://skyrimrequiem.ru");
        }
        /// <summary>
        /// Мой дискорд.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            MessageBox.Show("nolimit_Evsey#3704", "Discord");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1euxZqX4B2wIpdgbz_dKMrQWV8LB-btwnjCCyfN0KeI0/edit#gid=828854264");
        }
    }
}
