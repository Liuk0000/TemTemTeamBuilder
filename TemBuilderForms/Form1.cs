using Newtonsoft.Json;
using System.Text.Json;
using TemTemTeamBuilder.Models;
using TemTemTeamBuilder.Util;

namespace TemBuilderForms
{
    public partial class Form1 : Form
    {
        private IList<TemTem> _list;

        private TemTem[] _liveEditList;
        public Form1()
        {
            InitializeComponent();
        }        
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                LocalStorageHandler.CreateNewTeam(NewTeamTextBox.Text);
                ChooseTeamList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name not Valid");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _liveEditList = new TemTem[8];
            LocalStorageHandler.Properties();
            _list = Conversions.GetTemsList(LocalStorageHandler.JsonTemDataReader());
            ChooseTeamList();
        }
        private void TemChoice1_TextChanged(object sender, EventArgs e)
        {
            /*TemChoiceList(TemChoice1);
            TemChoice1.DroppedDown = true;*/
        }
        private void TemChoice1_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice1);
        }
        private void TemChoice2_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice2);
        }
        private void TemChoice3_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice3);
        }
        private void TemChoice4_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice4);
        }
        private void TemChoice5_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice5);
        }
        private void TemChoice6_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice6);
        }
        private void TemChoice7_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice7);
        }
        private void TemChoice8_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice8);
        }

        private void ChooseTeamList()
        {
            if(LocalStorageHandler.GetTeamsFileNames()!= null)
            {
                TeamChoiceComboBox.Items.Clear();
                foreach (string str in LocalStorageHandler.GetTeamsFileNames())
                {
                    TeamChoiceComboBox.Items.Add(str.Split('\\').Last());
                }
            }
        }

        private void TemChoiceList(ComboBox temChoice)
        {
            if (_list != null)
            {
                foreach (TemTem tem in this._list)
                {
                    temChoice.Items.Add(tem.Name);
                }
            }
        }
        private void TemChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemTem tem = _list.First(x => x.Name.Equals(TemChoice1.Items[TemChoice1.SelectedIndex].ToString()));
            tem.TrueStats = TrueStatsCalculator.CalculateTrueStats(tem);
            _liveEditList[0] = tem;
            ShowBaseStats(tem);
            SvsLoader(tem);
            TvsLoader(tem);
            ShowTrueStats(tem);

        }

        private void SvsLoader(TemTem tem)
        {
            hpSvUpDown.Value = Convert.ToDecimal(tem.Svs[0]);
            staSvUpDown.Value = Convert.ToDecimal(tem.Svs[1]);
            spdSvUpDown.Value = Convert.ToDecimal(tem.Svs[2]);
            atkSvUpDown.Value = Convert.ToDecimal(tem.Svs[3]);
            defSvUpDown.Value = Convert.ToDecimal(tem.Svs[4]);
            spatkSvUpDown.Value = Convert.ToDecimal(tem.Svs[5]);
            spdefSvUpDown.Value = Convert.ToDecimal(tem.Svs[6]);

        }
        private void TvsLoader(TemTem tem)
        {
            hpTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[0]);
            staTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[1]);
            spdTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[2]);
            atkTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[3]);
            defTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[4]);
            spatkTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[5]);
            spdefTvsUpDown.Value = Convert.ToDecimal(tem.Tvs[6]);
        }
        private void ShowBaseStats(TemTem tem)
        {
            baseStatsLabel.Text = "Base Stats:\n";

            foreach (int i in tem.Stats)
            {
                baseStatsLabel.Text += $" {i} ";
            }
        }
        private void ShowTrueStats(TemTem tem)
        {
            trueStatsLabel.Text = "True Stats:\n";

            foreach (int i in tem.TrueStats)
            {
               trueStatsLabel.Text += $" {i} ";
            }
        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            LocalStorageHandler.JsonTemDataWriter(API_Interactions.GetAllTemsAsString());
            this._list = Conversions.GetTemsList(LocalStorageHandler.JsonTemDataReader());
        }

        private void hpSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 0, hpSvUpDown.Value);
        }

        private void staSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 1, staSvUpDown.Value);
        }
        private void spdSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 2, spdSvUpDown.Value);
        }
        private void atkSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 3, atkSvUpDown.Value);
        }
        private void defSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 4, defSvUpDown.Value);
        }
        private void spatkSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 5, spatkSvUpDown.Value);
        }
        private void spdefSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 6, spdefSvUpDown.Value);
        }

        private void SvsValueUpdate(int temIndex, int svIndex, decimal numericUpDownValue)
        {
            _liveEditList[temIndex].Svs[svIndex] = Convert.ToDouble(numericUpDownValue);

            _liveEditList[temIndex].TrueStats = TrueStatsCalculator.CalculateTrueStats(_liveEditList[temIndex]);

            ShowTrueStats(_liveEditList[temIndex]);
        }

        private void TvsValueUpdate(int temIndex, int tvsIndex, decimal numericUpDownValue)
        {
            _liveEditList[temIndex].Tvs[tvsIndex] = Convert.ToDouble(numericUpDownValue);

            _liveEditList[temIndex].TrueStats = TrueStatsCalculator.CalculateTrueStats(_liveEditList[temIndex]);

            ShowTrueStats(_liveEditList[temIndex]);
        }

        private void hpTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 0, hpTvsUpDown.Value);
        }
        private void staTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 1, staTvsUpDown.Value);
        }

        private void spdTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 2, spdTvsUpDown.Value);
        }

        private void atkTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 3, atkTvsUpDown.Value);
        }

        private void defTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 4, defTvsUpDown.Value);
        }

        private void spatkTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 5, spatkTvsUpDown.Value);
        }
        private void spdefTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 6, spdefTvsUpDown.Value);
        }

        private void NewTeamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTeamButton_Click(object sender, EventArgs e)
        {
            LocalStorageHandler.TeamUpdate($@"{LocalStorageHandler.PropertiesDict["TeamsFolderPath"]}\{TeamChoiceComboBox.Items[TeamChoiceComboBox.SelectedIndex]}", JsonConvert.SerializeObject(_liveEditList));
        }

        private void ChooseTeamButton_Click(object sender, EventArgs e)
        {
            _liveEditList = Conversions.TeamJsonToArray(LocalStorageHandler.TeamReader($@"{LocalStorageHandler.PropertiesDict["TeamsFolderPath"]}\{TeamChoiceComboBox.Items[TeamChoiceComboBox.SelectedIndex]}"));

            ShowAllTemsFromTeam();
        }

        private void ShowTemFromTeam(ComboBox TemChoice, int index)
        {
            if(_liveEditList[index] != null)
            {
                TemChoice.Text = $"{_liveEditList[index].Name}_";

                ShowBaseStats(_liveEditList[index]);
                SvsLoader(_liveEditList[index]);
                TvsLoader(_liveEditList[index]);
                ShowTrueStats(_liveEditList[index]);
            }
        }

        private void ShowAllTemsFromTeam()
        {
            ShowTemFromTeam(TemChoice1, 0);
            ShowTemFromTeam(TemChoice2, 1);
            ShowTemFromTeam(TemChoice3, 2);
            ShowTemFromTeam(TemChoice4, 3);
            ShowTemFromTeam(TemChoice5, 4);
            ShowTemFromTeam(TemChoice6, 5);
            ShowTemFromTeam(TemChoice7, 6);
            ShowTemFromTeam(TemChoice8, 7);
        }

        private void TemChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}