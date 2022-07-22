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

        private NumericUpDown[][] _svsNumericUpDowns;

        private NumericUpDown[][] _tvsNumericUpDowns;

        private ComboBox[] _temsComboBoxes;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _liveEditList = new TemTem[8];
            LocalStorageHandler.Properties();
            _list = Conversions.GetTemsList(LocalStorageHandler.JsonTemDataReader());
            ChooseTeamList();
        }
        /*
         *
         *GENERIC METHODS
         *
         */
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
        /*
         * Loads List of Teams
         * */
        private void ChooseTeamList()
        {
            if (LocalStorageHandler.GetTeamsFileNames() != null)
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
        private void TemChoiceSelected(ComboBox TemChoice, int i, NumericUpDown[] svsUpDownArray, NumericUpDown[] tvsUpDownArray, Label baseStatsLabel, Label trueStatsLabel)
        {
            TemTem tem = _list.First(x => x.Name.Equals(TemChoice.Items[TemChoice.SelectedIndex].ToString()));
            tem.TrueStats = TrueStatsCalculator.CalculateTrueStats(tem);
            _liveEditList[i] = tem;
            ShowBaseStats(baseStatsLabel, tem);
            SvsLoader(svsUpDownArray, tem);
            TvsLoader(tvsUpDownArray, tem);
            ShowTrueStats(trueStatsLabel, tem);
            tem = null;
        }

        private void SvsLoader(NumericUpDown[] upDownArray, TemTem tem)
        {
            upDownArray[0].Value = Convert.ToDecimal(tem.Svs[0]);
            upDownArray[1].Value = Convert.ToDecimal(tem.Svs[1]);
            upDownArray[2].Value = Convert.ToDecimal(tem.Svs[2]);
            upDownArray[3].Value = Convert.ToDecimal(tem.Svs[3]);
            upDownArray[4].Value = Convert.ToDecimal(tem.Svs[4]);
            upDownArray[5].Value = Convert.ToDecimal(tem.Svs[5]);
            upDownArray[6].Value = Convert.ToDecimal(tem.Svs[6]);

        }
        private void TvsLoader(NumericUpDown[] upDownArray, TemTem tem)
        {
            upDownArray[0].Value = Convert.ToDecimal(tem.Tvs[0]);
            upDownArray[1].Value = Convert.ToDecimal(tem.Tvs[1]);
            upDownArray[2].Value = Convert.ToDecimal(tem.Tvs[2]);
            upDownArray[3].Value = Convert.ToDecimal(tem.Tvs[3]);
            upDownArray[4].Value = Convert.ToDecimal(tem.Tvs[4]);
            upDownArray[5].Value = Convert.ToDecimal(tem.Tvs[5]);
            upDownArray[6].Value = Convert.ToDecimal(tem.Tvs[6]);
        }
        private void ShowBaseStats(Label baseStatsLabel, TemTem tem)
        {
            baseStatsLabel.Text = "Base Stats:\n";

            foreach (int i in tem.Stats)
            {
                baseStatsLabel.Text += $" {i} ";
            }
        }
        private void ShowTrueStats(Label trueStatsLabel, TemTem tem)
        {
            trueStatsLabel.Text = "True Stats:\n";

            foreach (int i in tem.TrueStats)
            {
                trueStatsLabel.Text += $" {i} ";
            }
        }
        private void SvsValueUpdate(int temIndex, int svIndex, decimal numericUpDownValue, Label trueStatsLabel)
        {
            _liveEditList[temIndex].Svs[svIndex] = Convert.ToDouble(numericUpDownValue);

            _liveEditList[temIndex].TrueStats = TrueStatsCalculator.CalculateTrueStats(_liveEditList[temIndex]);

            ShowTrueStats(trueStatsLabel, _liveEditList[temIndex]);
        }

        private void TvsValueUpdate(int temIndex, int tvsIndex, decimal numericUpDownValue, Label trueStatsLabel)
        {
            _liveEditList[temIndex].Tvs[tvsIndex] = Convert.ToDouble(numericUpDownValue);

            _liveEditList[temIndex].TrueStats = TrueStatsCalculator.CalculateTrueStats(_liveEditList[temIndex]);

            ShowTrueStats(trueStatsLabel, _liveEditList[temIndex]);
        }
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            LocalStorageHandler.JsonTemDataWriter(API_Interactions.GetAllTemsAsString());
            this._list = Conversions.GetTemsList(LocalStorageHandler.JsonTemDataReader());
        }
        private void UpdateTeamButton_Click(object sender, EventArgs e)
        {
            LocalStorageHandler.TeamUpdate($@"{LocalStorageHandler.PropertiesDict["TeamsFolderPath"]}\{TeamChoiceComboBox.Items[TeamChoiceComboBox.SelectedIndex]}", JsonConvert.SerializeObject(_liveEditList));
        }
        private void ShowTemFromTeam(ComboBox TemChoice, int index, NumericUpDown[] svsUpDownArray, NumericUpDown[] tvsUpDownArray, Label baseStatsLabel, Label trueStatsLabel)
        {
            if (_liveEditList[index] != null)
            {
                TemChoice.Text = $"{_liveEditList[index].Name}_";

                ShowBaseStats(baseStatsLabel, _liveEditList[index]);
                SvsLoader(svsUpDownArray, _liveEditList[index]);
                TvsLoader(tvsUpDownArray, _liveEditList[index]);
                ShowTrueStats(trueStatsLabel, _liveEditList[index]);
            }
        }

        private void ShowAllTemsFromTeam(NumericUpDown[][] svsNumericUpDowns, NumericUpDown[][] tvsNumericUpDowns)
        {
            ShowTemFromTeam(TemChoice1, 0, svsNumericUpDowns[0], tvsNumericUpDowns[0], baseStatsLabel, trueStatsLabel);
            ShowTemFromTeam(TemChoice2, 1, svsNumericUpDowns[1], tvsNumericUpDowns[1], baseStatsLabel2, trueStatsLabel2);
            /*ShowTemFromTeam(TemChoice3, 2, numericUpDowns[2]);
            ShowTemFromTeam(TemChoice4, 3, numericUpDowns[3]);
            ShowTemFromTeam(TemChoice5, 4, numericUpDowns[4]);
            ShowTemFromTeam(TemChoice6, 5, numericUpDowns[5]);
            ShowTemFromTeam(TemChoice7, 6, numericUpDowns[6]);
            ShowTemFromTeam(TemChoice8, 7, numericUpDowns[7]);*/
        }
        private void ChooseTeamButton_Click(object sender, EventArgs e)
        {
            _liveEditList = Conversions.TeamJsonToArray(LocalStorageHandler.TeamReader($@"{LocalStorageHandler.PropertiesDict["TeamsFolderPath"]}\{TeamChoiceComboBox.Items[TeamChoiceComboBox.SelectedIndex]}"));

            ShowAllTemsFromTeam(new NumericUpDown[][]
            {
                new NumericUpDown[] { hpSvUpDown, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },
                new NumericUpDown[] { hpSvUpDown2, staSvUpDown2, spdSvUpDown2, atkSvUpDown2, defSvUpDown2, spatkSvUpDown2, spdefSvUpDown2 }/*,
                new NumericUpDown[] { hpSvUpDown3, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },
                new NumericUpDown[] { hpSvUpDown3, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },
                new NumericUpDown[] { hpSvUpDown4, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },
                new NumericUpDown[] { hpSvUpDown5, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },
                new NumericUpDown[] { hpSvUpDown6, staSvUpDown, spdSvUpDown, atkSvUpDown, defSvUpDown, spatkSvUpDown, spdefSvUpDown },*/
            },
            new NumericUpDown[][]
            {
                new NumericUpDown[]{hpTvsUpDown, staTvsUpDown, spdTvsUpDown, atkTvsUpDown, defTvsUpDown, spatkTvsUpDown, spdefTvsUpDown},
                new NumericUpDown[]{hpTvsUpDown2, staTvsUpDown2, spdTvsUpDown2, atkTvsUpDown2, defTvsUpDown2, spatkTvsUpDown2, spdefTvsUpDown2}
            });
        }
        /*
         * 
         * TEM 1
         * 
         * 
         * */
        private void TemChoice1_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice1);
        }
        private void TemChoice1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemChoiceSelected(TemChoice1,0, 
            new NumericUpDown[]
            {
                hpSvUpDown,staSvUpDown,spdSvUpDown,atkSvUpDown,defSvUpDown,spatkSvUpDown,spdefSvUpDown
            },
            new NumericUpDown[]
            {
              hpTvsUpDown,staTvsUpDown,spdTvsUpDown,atkTvsUpDown,defTvsUpDown,spatkTvsUpDown,spdefTvsUpDown
            },
            baseStatsLabel,trueStatsLabel);
        }
        /*
         * SVS NUMDOWN 1
         * */
        private void hpSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 0, hpSvUpDown.Value, trueStatsLabel);
        }
        private void staSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 1, staSvUpDown.Value,trueStatsLabel);
        }
        private void spdSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 2, spdSvUpDown.Value,trueStatsLabel);
        }
        private void atkSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 3, atkSvUpDown.Value,trueStatsLabel);
        }
        private void defSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 4, defSvUpDown.Value, trueStatsLabel);
        }
        private void spatkSvNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 5, spatkSvUpDown.Value,trueStatsLabel);
        }
        private void spdefSvUpDown_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(0, 6, spdefSvUpDown.Value, trueStatsLabel);
        }
        /*
         * TVS NUMDOWN 1
         * */
        private void hpTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 0, hpTvsUpDown.Value, trueStatsLabel);
        }
        private void staTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 1, staTvsUpDown.Value, trueStatsLabel);
        }
        private void spdTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 2, spdTvsUpDown.Value, trueStatsLabel);
        }
        private void atkTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 3, atkTvsUpDown.Value, trueStatsLabel);
        }
        private void defTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 4, defTvsUpDown.Value, trueStatsLabel);
        }
        private void spatkTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 5, spatkTvsUpDown.Value, trueStatsLabel);
        }
        private void spdefTvsUpDown_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(0, 6, spdefTvsUpDown.Value, trueStatsLabel);
        }



        /*
         * TEM 2
         * */
        private void TemChoice2_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice2);
        }
        private void TemChoice2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemChoiceSelected(TemChoice2, 1, new NumericUpDown[]
            {
                hpSvUpDown2,staSvUpDown2,spdSvUpDown2,atkSvUpDown2,defSvUpDown2,spatkSvUpDown2,spdefSvUpDown2
            },
            new NumericUpDown[]
            {
              hpTvsUpDown2,staTvsUpDown2,spdTvsUpDown2,atkTvsUpDown2,defTvsUpDown2,spatkTvsUpDown2,spdefTvsUpDown2
            },
            baseStatsLabel2, trueStatsLabel2);
        }
        /*
         * SV NUMDOWN 2
         * */
        private void hpSvNumUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 0, hpSvUpDown2.Value, trueStatsLabel2);
        }
        private void staSvNumUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 1, staSvUpDown2.Value, trueStatsLabel2);
        }
        private void spdSvUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 2, spdSvUpDown2.Value, trueStatsLabel2);
        }
        private void atkSvUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 3, atkSvUpDown2.Value, trueStatsLabel2);
        }
        private void defSvNumUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 4, defSvUpDown2.Value, trueStatsLabel2);
        }
        private void spatkSvNumUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 5, spatkSvUpDown2.Value, trueStatsLabel2);
        }
        private void spdefSvUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SvsValueUpdate(1, 6, spdefSvUpDown2.Value, trueStatsLabel2);
        }
        /*
         * TVS NUMDOWN 2
         * */
        private void hpTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 0, hpTvsUpDown2.Value, trueStatsLabel2);
        }
        private void staTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 1, staTvsUpDown2.Value, trueStatsLabel2);
        }
        private void spdTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 2, spdTvsUpDown2.Value, trueStatsLabel2);
        }
        private void atkTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 3, atkTvsUpDown2.Value, trueStatsLabel2);
        }
        private void defTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 4, defTvsUpDown2.Value, trueStatsLabel2);
        }
        private void spatkTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 5, spatkTvsUpDown2.Value, trueStatsLabel2);
        }
        private void spdefTvsUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TvsValueUpdate(1, 6, spdefTvsUpDown2.Value, trueStatsLabel2);
        }

        /*
         * 
         * TEM 3
         * */
        private void TemChoice3_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice3);
        }
        private void TemChoice3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * 
         * TEM 4
         * */
        private void TemChoice4_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice4);
        }
        private void TemChoice4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * 
         * TEM 5
         * */
        private void TemChoice5_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice5);
        }
        private void TemChoice5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * 
         * TEM 6
         * */
        private void TemChoice6_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice6);
        }
        private void TemChoice6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * 
         * TEM 7
         * */
        private void TemChoice7_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice7);
        }
        private void TemChoice7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
         * 
         * TEM 8
         * */
        private void TemChoice8_DropDown(object sender, EventArgs e)
        {
            TemChoiceList(TemChoice8);
        }
        private void TemChoice8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}