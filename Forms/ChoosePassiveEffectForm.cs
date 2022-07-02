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
    public partial class ChoosePassiveEffectForm : Form
    {
        public ChoosePassiveEffectForm(List<IBasePassiveEffect> effects, CreateCharacterForm ccForm)
        {
            InitializeComponent();
            _ccForm = ccForm ?? throw new ArgumentNullException(nameof(ccForm));
            _effects = effects ?? throw new ArgumentNullException(nameof(effects));
        }

        readonly CreateCharacterForm _ccForm;
        readonly List<IBasePassiveEffect> _effects;
        PassiveEffectType effectsType;
        private void Button1_Click(object sender, EventArgs e)
        {
            switch(effectsType)
            {
                case PassiveEffectType.GodBlessing:
                    AddOne();
                    break;
                case PassiveEffectType.CivilWar:
                    AddOne();
                    break;
                case PassiveEffectType.BlessingOfNature:
                    AddOne();
                    break;
                case PassiveEffectType.AllMakerStone:
                    AddOne();
                    break;
                default:
                    AddMany();
                    break;
            }
        }
        private void AddOne()
        {
            try
            {
                List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                IBasePassiveEffect chosenEffect = _effects[indexes.FirstOrDefault()];
                int powerLevel = Convert.ToInt32(comboBox1.SelectedItem);
                chosenEffect.PowerLevel = powerLevel;
                if (chosenEffect != null)
                {
                    switch(effectsType)
                    {
                        case PassiveEffectType.GodBlessing: 
                            _ccForm.YourChar.God = chosenEffect; 
                            break;
                        case PassiveEffectType.CivilWar: 
                            _ccForm.YourChar.Effects.AddOverwriteSearchByType(chosenEffect); 
                            break;
                        case PassiveEffectType.BlessingOfNature: 
                            _ccForm.YourChar.Effects.AddOverwriteSearchByType(chosenEffect); 
                            break;
                        case PassiveEffectType.AllMakerStone:
                            _ccForm.YourChar.Effects.AddOverwriteSearchByType(chosenEffect);
                            break;
                        default:
                            throw new Exception("Нельзя добавить данный эффект, так как необходимо добавление группой!" + effectsType);

                    }
                    _ccForm.UpdateElements();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }
        private void AddMany()
        {
            try
            {
                List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
                List<IBasePassiveEffect> chosenEffects = _effects.GetGroupByIndexes(indexes);
                int powerLevel = Convert.ToInt32(comboBox1.SelectedItem);
                foreach (IBasePassiveEffect effect in chosenEffects)
                {
                    effect.PowerLevel = powerLevel;
                }
                if (chosenEffects != null)
                {
                    if (!checkBox1.Checked)
                    {
                        _ccForm.YourChar.Effects.AddUniqManyPassiveEffects(chosenEffects);
                    }
                    else
                    {
                        _ccForm.YourChar.Effects.AddManyOverwriteSearchByType(chosenEffects);
                    }
                    _ccForm.UpdateElements();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }

        private void ChoosePassiveEffectForm_Load(object sender, EventArgs e)
        {
            effectsType = _effects.Select(x => x.Type).FirstOrDefault();
            Logger.Info("Loaded choose passive effect form with data: " + effectsType.ToString());
            dataGridView1.DataSource = _effects;
            BackColor = _effects.Select(x => x.Color).FirstOrDefault();
            comboBox1.Text = 1.ToString();
            switch(effectsType)
            {
                case PassiveEffectType.GodBlessing: Text = "Божества"; break;
                case PassiveEffectType.MainStory: Text = "Основной сюжет"; break;
                case PassiveEffectType.CivilWar: Text = "Гражданская война"; break;
                case PassiveEffectType.BlessingOfNature: Text = "Чудо природы"; break;
                case PassiveEffectType.Guilds: Text = "Гильдии"; break;
                case PassiveEffectType.BlackBooks: Text = "Черные книги"; break;
                case PassiveEffectType.AllMakerStone: Text = "Камни Всесоздателя"; break;
                case PassiveEffectType.Another: Text = "Разное"; break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<int> indexes = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Index).ToList();
            List<IBasePassiveEffect> chosenEffects = _effects.GetGroupByIndexes(indexes);
            Logger.Info("Try to delete selected items from character effects: ");
            Logger.Info(chosenEffects);
            _ccForm.YourChar.Effects.RemoveManySearchByName(chosenEffects);
            _ccForm.UpdateElements();
            this.Close();
        }
    }
}
