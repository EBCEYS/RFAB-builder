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
    public partial class ChooseStoneForm : Form
    {
        public ChooseStoneForm(CreateCharacterForm ccForm)
        {
            InitializeComponent();
            CcForm = ccForm;
        }

        readonly CreateCharacterForm CcForm;

        private void ChooseStoneForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Storage.Stones;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Logger.Info("Open choose stone form");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                IBaseStone choosenStone = Storage.Stones[indexes.FirstOrDefault()];
                if (choosenStone != null)
                {
                    Logger.Info($"Choosen stone is {choosenStone}");
                    CcForm.YourChar.Stone = choosenStone;
                    CcForm.UpdateElements();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }
    }
}
