using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class ChooseRaceForm : Form
    {
        public ChooseRaceForm(CreateCharacterForm ccForm)
        {
            InitializeComponent();
            CcForm = ccForm;
        }

        readonly CreateCharacterForm CcForm;
        private void ChooseRaceForm_Load(object sender, EventArgs e)
        {
            Logger.Info("Open choose race form");
            dataGridView1.DataSource = Storage.Races;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                IBaseRace choosenRace = Storage.Races[indexes.FirstOrDefault()];
                string name = !string.IsNullOrEmpty(textBox1.Text) ? textBox1.Text : throw new Exception($"Не введено имя персонажа!{Environment.NewLine}Введите имя персонажа");
                if (choosenRace != null)
                {
                    if (CcForm.YourChar == null)
                    {
                        CcForm.YourChar = new Characters(choosenRace, name);
                    }
                    else
                    {
                        CcForm.YourChar.Race = choosenRace;
                        if (!string.IsNullOrEmpty(name))
                        {
                            CcForm.YourChar.Name = name;
                        }
                    }
                    Logger.Info($"Created character: {CcForm.YourChar.Name} with race {CcForm.YourChar.Race.Name}");
                    CcForm.UpdateElements();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }
    }
}
