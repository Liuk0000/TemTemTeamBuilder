namespace TemBuilderForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.NewTeamTextBox = new System.Windows.Forms.TextBox();
            this.ChooseTeamButton = new System.Windows.Forms.Button();
            this.TeamChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.TemChoice1 = new System.Windows.Forms.ComboBox();
            this.baseStatsLabel = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.trueStatsLabel = new System.Windows.Forms.Label();
            this.hpSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.staSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.spdSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.atkSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.defSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.spatkSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.spdefSvUpDown = new System.Windows.Forms.NumericUpDown();
            this.spdefTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.spatkTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.defTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.atkTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.spdTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.staTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.hpTvsUpDown = new System.Windows.Forms.NumericUpDown();
            this.UpdateTeamButton = new System.Windows.Forms.Button();
            this.TemChoice2 = new System.Windows.Forms.ComboBox();
            this.TemChoice6 = new System.Windows.Forms.ComboBox();
            this.TemChoice5 = new System.Windows.Forms.ComboBox();
            this.TemChoice4 = new System.Windows.Forms.ComboBox();
            this.TemChoice3 = new System.Windows.Forms.ComboBox();
            this.TemChoice7 = new System.Windows.Forms.ComboBox();
            this.TemChoice8 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hpSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatkSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdefSvUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdefTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatkTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staTvsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTvsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(1185, 26);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(104, 27);
            this.CreateTeamButton.TabIndex = 1;
            this.CreateTeamButton.Text = "NewTeam";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // NewTeamTextBox
            // 
            this.NewTeamTextBox.Location = new System.Drawing.Point(990, 26);
            this.NewTeamTextBox.Name = "NewTeamTextBox";
            this.NewTeamTextBox.Size = new System.Drawing.Size(189, 27);
            this.NewTeamTextBox.TabIndex = 2;
            this.NewTeamTextBox.TextChanged += new System.EventHandler(this.NewTeamTextBox_TextChanged);
            // 
            // ChooseTeamButton
            // 
            this.ChooseTeamButton.Location = new System.Drawing.Point(1185, 75);
            this.ChooseTeamButton.Name = "ChooseTeamButton";
            this.ChooseTeamButton.Size = new System.Drawing.Size(104, 29);
            this.ChooseTeamButton.TabIndex = 4;
            this.ChooseTeamButton.Text = "ChooseTeam";
            this.ChooseTeamButton.UseVisualStyleBackColor = true;
            this.ChooseTeamButton.Click += new System.EventHandler(this.ChooseTeamButton_Click);
            // 
            // TeamChoiceComboBox
            // 
            this.TeamChoiceComboBox.FormattingEnabled = true;
            this.TeamChoiceComboBox.Location = new System.Drawing.Point(990, 76);
            this.TeamChoiceComboBox.Name = "TeamChoiceComboBox";
            this.TeamChoiceComboBox.Size = new System.Drawing.Size(189, 28);
            this.TeamChoiceComboBox.TabIndex = 6;
            this.TeamChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamChoiceComboBox_SelectedIndexChanged);
            // 
            // TemChoice1
            // 
            this.TemChoice1.FormattingEnabled = true;
            this.TemChoice1.Location = new System.Drawing.Point(12, 25);
            this.TemChoice1.Name = "TemChoice1";
            this.TemChoice1.Size = new System.Drawing.Size(228, 28);
            this.TemChoice1.TabIndex = 7;
            this.TemChoice1.DropDown += new System.EventHandler(this.TemChoice1_DropDown);
            this.TemChoice1.SelectedIndexChanged += new System.EventHandler(this.TemChoice1_SelectedIndexChanged);
            this.TemChoice1.TextChanged += new System.EventHandler(this.TemChoice1_TextChanged);
            // 
            // baseStatsLabel
            // 
            this.baseStatsLabel.AutoSize = true;
            this.baseStatsLabel.Location = new System.Drawing.Point(257, 29);
            this.baseStatsLabel.Name = "baseStatsLabel";
            this.baseStatsLabel.Size = new System.Drawing.Size(83, 20);
            this.baseStatsLabel.TabIndex = 8;
            this.baseStatsLabel.Text = "Base Stats :\r\n";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(1034, 258);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(119, 29);
            this.DownloadButton.TabIndex = 9;
            this.DownloadButton.Text = "DownloadData";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // trueStatsLabel
            // 
            this.trueStatsLabel.AutoSize = true;
            this.trueStatsLabel.Location = new System.Drawing.Point(257, 76);
            this.trueStatsLabel.Name = "trueStatsLabel";
            this.trueStatsLabel.Size = new System.Drawing.Size(76, 20);
            this.trueStatsLabel.TabIndex = 10;
            this.trueStatsLabel.Text = "True Stats:";
            this.trueStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hpSvUpDown
            // 
            this.hpSvUpDown.Location = new System.Drawing.Point(12, 77);
            this.hpSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.hpSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hpSvUpDown.Name = "hpSvUpDown";
            this.hpSvUpDown.Size = new System.Drawing.Size(40, 27);
            this.hpSvUpDown.TabIndex = 11;
            this.hpSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hpSvUpDown.ValueChanged += new System.EventHandler(this.hpSvNumUpDown_ValueChanged);
            // 
            // staSvUpDown
            // 
            this.staSvUpDown.Location = new System.Drawing.Point(12, 107);
            this.staSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.staSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.staSvUpDown.Name = "staSvUpDown";
            this.staSvUpDown.Size = new System.Drawing.Size(40, 27);
            this.staSvUpDown.TabIndex = 12;
            this.staSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.staSvUpDown.ValueChanged += new System.EventHandler(this.staSvNumUpDown_ValueChanged);
            // 
            // spdSvUpDown
            // 
            this.spdSvUpDown.Location = new System.Drawing.Point(12, 137);
            this.spdSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spdSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spdSvUpDown.Name = "spdSvUpDown";
            this.spdSvUpDown.Size = new System.Drawing.Size(40, 27);
            this.spdSvUpDown.TabIndex = 13;
            this.spdSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spdSvUpDown.ValueChanged += new System.EventHandler(this.spdSvUpDown_ValueChanged);
            // 
            // atkSvUpDown
            // 
            this.atkSvUpDown.Location = new System.Drawing.Point(11, 168);
            this.atkSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.atkSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.atkSvUpDown.Name = "atkSvUpDown";
            this.atkSvUpDown.Size = new System.Drawing.Size(40, 27);
            this.atkSvUpDown.TabIndex = 14;
            this.atkSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.atkSvUpDown.ValueChanged += new System.EventHandler(this.atkSvUpDown_ValueChanged);
            // 
            // defSvUpDown
            // 
            this.defSvUpDown.Location = new System.Drawing.Point(12, 198);
            this.defSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.defSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.defSvUpDown.Name = "defSvUpDown";
            this.defSvUpDown.Size = new System.Drawing.Size(39, 27);
            this.defSvUpDown.TabIndex = 15;
            this.defSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.defSvUpDown.ValueChanged += new System.EventHandler(this.defSvNumUpDown_ValueChanged);
            // 
            // spatkSvUpDown
            // 
            this.spatkSvUpDown.Location = new System.Drawing.Point(12, 228);
            this.spatkSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spatkSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spatkSvUpDown.Name = "spatkSvUpDown";
            this.spatkSvUpDown.Size = new System.Drawing.Size(39, 27);
            this.spatkSvUpDown.TabIndex = 16;
            this.spatkSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spatkSvUpDown.ValueChanged += new System.EventHandler(this.spatkSvNumUpDown_ValueChanged);
            // 
            // spdefSvUpDown
            // 
            this.spdefSvUpDown.Location = new System.Drawing.Point(11, 258);
            this.spdefSvUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spdefSvUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spdefSvUpDown.Name = "spdefSvUpDown";
            this.spdefSvUpDown.Size = new System.Drawing.Size(40, 27);
            this.spdefSvUpDown.TabIndex = 17;
            this.spdefSvUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spdefSvUpDown.ValueChanged += new System.EventHandler(this.spdefSvUpDown_ValueChanged);
            // 
            // spdefTvsUpDown
            // 
            this.spdefTvsUpDown.Location = new System.Drawing.Point(58, 258);
            this.spdefTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spdefTvsUpDown.Name = "spdefTvsUpDown";
            this.spdefTvsUpDown.Size = new System.Drawing.Size(54, 27);
            this.spdefTvsUpDown.TabIndex = 24;
            this.spdefTvsUpDown.ValueChanged += new System.EventHandler(this.spdefTvsUpDown_ValueChanged);
            // 
            // spatkTvsUpDown
            // 
            this.spatkTvsUpDown.Location = new System.Drawing.Point(57, 228);
            this.spatkTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spatkTvsUpDown.Name = "spatkTvsUpDown";
            this.spatkTvsUpDown.Size = new System.Drawing.Size(55, 27);
            this.spatkTvsUpDown.TabIndex = 23;
            this.spatkTvsUpDown.ValueChanged += new System.EventHandler(this.spatkTvsUpDown_ValueChanged);
            // 
            // defTvsUpDown
            // 
            this.defTvsUpDown.Location = new System.Drawing.Point(57, 198);
            this.defTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.defTvsUpDown.Name = "defTvsUpDown";
            this.defTvsUpDown.Size = new System.Drawing.Size(55, 27);
            this.defTvsUpDown.TabIndex = 22;
            this.defTvsUpDown.ValueChanged += new System.EventHandler(this.defTvsUpDown_ValueChanged);
            // 
            // atkTvsUpDown
            // 
            this.atkTvsUpDown.Location = new System.Drawing.Point(57, 168);
            this.atkTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.atkTvsUpDown.Name = "atkTvsUpDown";
            this.atkTvsUpDown.Size = new System.Drawing.Size(55, 27);
            this.atkTvsUpDown.TabIndex = 21;
            this.atkTvsUpDown.ValueChanged += new System.EventHandler(this.atkTvsUpDown_ValueChanged);
            // 
            // spdTvsUpDown
            // 
            this.spdTvsUpDown.Location = new System.Drawing.Point(58, 137);
            this.spdTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spdTvsUpDown.Name = "spdTvsUpDown";
            this.spdTvsUpDown.Size = new System.Drawing.Size(54, 27);
            this.spdTvsUpDown.TabIndex = 20;
            this.spdTvsUpDown.ValueChanged += new System.EventHandler(this.spdTvsUpDown_ValueChanged);
            // 
            // staTvsUpDown
            // 
            this.staTvsUpDown.Location = new System.Drawing.Point(58, 107);
            this.staTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.staTvsUpDown.Name = "staTvsUpDown";
            this.staTvsUpDown.Size = new System.Drawing.Size(54, 27);
            this.staTvsUpDown.TabIndex = 19;
            this.staTvsUpDown.ValueChanged += new System.EventHandler(this.staTvsUpDown_ValueChanged);
            // 
            // hpTvsUpDown
            // 
            this.hpTvsUpDown.Location = new System.Drawing.Point(58, 77);
            this.hpTvsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hpTvsUpDown.Name = "hpTvsUpDown";
            this.hpTvsUpDown.Size = new System.Drawing.Size(54, 27);
            this.hpTvsUpDown.TabIndex = 18;
            this.hpTvsUpDown.ValueChanged += new System.EventHandler(this.hpTvsUpDown_ValueChanged);
            // 
            // UpdateTeamButton
            // 
            this.UpdateTeamButton.Location = new System.Drawing.Point(1034, 177);
            this.UpdateTeamButton.Name = "UpdateTeamButton";
            this.UpdateTeamButton.Size = new System.Drawing.Size(102, 29);
            this.UpdateTeamButton.TabIndex = 25;
            this.UpdateTeamButton.Text = "UpdateTeam";
            this.UpdateTeamButton.UseVisualStyleBackColor = true;
            this.UpdateTeamButton.Click += new System.EventHandler(this.UpdateTeamButton_Click);
            // 
            // TemChoice2
            // 
            this.TemChoice2.FormattingEnabled = true;
            this.TemChoice2.Location = new System.Drawing.Point(12, 322);
            this.TemChoice2.Name = "TemChoice2";
            this.TemChoice2.Size = new System.Drawing.Size(228, 28);
            this.TemChoice2.TabIndex = 26;
            this.TemChoice2.DropDown += new System.EventHandler(this.TemChoice2_DropDown);
            this.TemChoice2.SelectedIndexChanged += new System.EventHandler(this.TemChoice2_SelectedIndexChanged);
            // 
            // TemChoice6
            // 
            this.TemChoice6.FormattingEnabled = true;
            this.TemChoice6.Location = new System.Drawing.Point(12, 526);
            this.TemChoice6.Name = "TemChoice6";
            this.TemChoice6.Size = new System.Drawing.Size(228, 28);
            this.TemChoice6.TabIndex = 27;
            this.TemChoice6.DropDown += new System.EventHandler(this.TemChoice6_DropDown);
            // 
            // TemChoice5
            // 
            this.TemChoice5.FormattingEnabled = true;
            this.TemChoice5.Location = new System.Drawing.Point(12, 478);
            this.TemChoice5.Name = "TemChoice5";
            this.TemChoice5.Size = new System.Drawing.Size(228, 28);
            this.TemChoice5.TabIndex = 28;
            this.TemChoice5.DropDown += new System.EventHandler(this.TemChoice5_DropDown);
            // 
            // TemChoice4
            // 
            this.TemChoice4.FormattingEnabled = true;
            this.TemChoice4.Location = new System.Drawing.Point(12, 428);
            this.TemChoice4.Name = "TemChoice4";
            this.TemChoice4.Size = new System.Drawing.Size(228, 28);
            this.TemChoice4.TabIndex = 29;
            this.TemChoice4.DropDown += new System.EventHandler(this.TemChoice4_DropDown);
            // 
            // TemChoice3
            // 
            this.TemChoice3.FormattingEnabled = true;
            this.TemChoice3.Location = new System.Drawing.Point(12, 371);
            this.TemChoice3.Name = "TemChoice3";
            this.TemChoice3.Size = new System.Drawing.Size(228, 28);
            this.TemChoice3.TabIndex = 30;
            this.TemChoice3.DropDown += new System.EventHandler(this.TemChoice3_DropDown);
            // 
            // TemChoice7
            // 
            this.TemChoice7.FormattingEnabled = true;
            this.TemChoice7.Location = new System.Drawing.Point(12, 586);
            this.TemChoice7.Name = "TemChoice7";
            this.TemChoice7.Size = new System.Drawing.Size(228, 28);
            this.TemChoice7.TabIndex = 31;
            this.TemChoice7.DropDown += new System.EventHandler(this.TemChoice7_DropDown);
            // 
            // TemChoice8
            // 
            this.TemChoice8.FormattingEnabled = true;
            this.TemChoice8.Location = new System.Drawing.Point(11, 632);
            this.TemChoice8.Name = "TemChoice8";
            this.TemChoice8.Size = new System.Drawing.Size(228, 28);
            this.TemChoice8.TabIndex = 32;
            this.TemChoice8.DropDown += new System.EventHandler(this.TemChoice8_DropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 755);
            this.Controls.Add(this.TemChoice8);
            this.Controls.Add(this.TemChoice7);
            this.Controls.Add(this.TemChoice3);
            this.Controls.Add(this.TemChoice4);
            this.Controls.Add(this.TemChoice5);
            this.Controls.Add(this.TemChoice6);
            this.Controls.Add(this.TemChoice2);
            this.Controls.Add(this.UpdateTeamButton);
            this.Controls.Add(this.spdefTvsUpDown);
            this.Controls.Add(this.spatkTvsUpDown);
            this.Controls.Add(this.defTvsUpDown);
            this.Controls.Add(this.atkTvsUpDown);
            this.Controls.Add(this.spdTvsUpDown);
            this.Controls.Add(this.staTvsUpDown);
            this.Controls.Add(this.hpTvsUpDown);
            this.Controls.Add(this.spdefSvUpDown);
            this.Controls.Add(this.spatkSvUpDown);
            this.Controls.Add(this.defSvUpDown);
            this.Controls.Add(this.atkSvUpDown);
            this.Controls.Add(this.spdSvUpDown);
            this.Controls.Add(this.staSvUpDown);
            this.Controls.Add(this.hpSvUpDown);
            this.Controls.Add(this.trueStatsLabel);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.baseStatsLabel);
            this.Controls.Add(this.TemChoice1);
            this.Controls.Add(this.TeamChoiceComboBox);
            this.Controls.Add(this.ChooseTeamButton);
            this.Controls.Add(this.NewTeamTextBox);
            this.Controls.Add(this.CreateTeamButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hpSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatkSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdefSvUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdefTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatkTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atkTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staTvsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpTvsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CreateTeamButton;
        private TextBox NewTeamTextBox;
        private Button ChooseTeamButton;
        private ComboBox TeamChoiceComboBox;
        private ComboBox TemChoice1;
        private Label baseStatsLabel;
        private Button DownloadButton;
        private Label trueStatsLabel;
        private NumericUpDown hpSvUpDown;
        private NumericUpDown staSvUpDown;
        private NumericUpDown spdSvUpDown;
        private NumericUpDown atkSvUpDown;
        private NumericUpDown defSvUpDown;
        private NumericUpDown spatkSvUpDown;
        private NumericUpDown spdefSvUpDown;
        private NumericUpDown spdefTvsUpDown;
        private NumericUpDown spatkTvsUpDown;
        private NumericUpDown defTvsUpDown;
        private NumericUpDown atkTvsUpDown;
        private NumericUpDown spdTvsUpDown;
        private NumericUpDown staTvsUpDown;
        private NumericUpDown hpTvsUpDown;
        private Button UpdateTeamButton;
        private ComboBox TemChoice2;
        private ComboBox TemChoice6;
        private ComboBox TemChoice5;
        private ComboBox TemChoice4;
        private ComboBox TemChoice3;
        private ComboBox TemChoice7;
        private ComboBox TemChoice8;
    }
}