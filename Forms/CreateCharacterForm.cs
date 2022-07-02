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
            YourChar.Effect();
            RaceLabel.Text = "Раса: " + YourChar.Race.Name;
            RaceLabel.Update();
            NameLabel.Text = "Имя: " + YourChar.Name;
            NameLabel.Update();
            StoneLabel.Text = "Камень: " + (!string.IsNullOrEmpty(YourChar.Stone?.Name)? YourChar.Stone?.Name : "камень не выбран");
            StoneLabel.Update();
            GodLabel.Text = "Бог: " + YourChar.God?.Name ?? "бог не выбран";
            GodLabel.Update();
            HPLabel.Text = $"ХП: {YourChar.WhiteHP} + ({YourChar.BlueHP}) = {YourChar.WhiteHP + YourChar.BlueHP}";
            HPLabel.Update();
            MPLabel.Text = $"МП: {YourChar.WhiteMana} + ({YourChar.BlueMana}) = {YourChar.WhiteMana + YourChar.BlueMana}";
            MPLabel.Update();
            STLabel.Text = $"СТ: {YourChar.WhiteStamina} + ({YourChar.BlueStamina}) = {YourChar.WhiteStamina + YourChar.BlueStamina}";
            STLabel.Update();

            HPRegenLabel.Text = $"ХП реген: {YourChar.HPRegenFact}";
            MPRegenLabel.Text = $"МП реген: {YourChar.MPRegenFact}";
            STRegenLabel.Text = $"СТ реген: {YourChar.STRegenFact}";

            if (YourChar.Effects != null)
            {
                PassiveEffectsDataGridView.DataSource = YourChar.Effects.ToArray();
                PassiveEffectsDataGridView.Update();
            }
            if (YourChar.Inventory != null)
            {
                EquipmentDataGridView.DataSource = YourChar.Inventory.Select(x => (x.Slot, x.Name));
                EquipmentDataGridView.Update();
            }
        }

        private void CreateCharacterForm_Load(object sender, EventArgs e)
        {
            Logger.Info("Show create character form");
            Text = "Меню выбора персонажа";
            BackgroundImage = Properties.Resources.MainMenuBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
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

        private void ОсновнойСюжетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.MainQuestEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void ГильдииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.GuildsEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void ГражданскаяВойнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.CivilWarEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void ЧудоПриродыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.BlessingOfNatureEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void ЧерныеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.BlackBooksEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void KамниВсесоздателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.AllMakerStonesEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void PазноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.AnotherEffects, this);
            choosePassiveEffectForm.Show();
        }

        private void БогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePassiveEffectForm choosePassiveEffectForm = new ChoosePassiveEffectForm(Storage.GodsEffects, this);
            choosePassiveEffectForm.Show();
        }
    }
}
