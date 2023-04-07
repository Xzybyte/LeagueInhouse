namespace LeagueInhouse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.summonerText = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.lobbyGrid = new System.Windows.Forms.DataGridView();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lobbyLabel = new System.Windows.Forms.Label();
            this.team1Grid = new System.Windows.Forms.DataGridView();
            this.Members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1Label = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.champPicture = new System.Windows.Forms.PictureBox();
            this.rankPicture = new System.Windows.Forms.PictureBox();
            this.mpcLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.summonerLabel = new System.Windows.Forms.Label();
            this.addToLobbyButton = new System.Windows.Forms.Button();
            this.lobbyClearButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.regionList = new System.Windows.Forms.ComboBox();
            this.unrankedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.apiKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lobbyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // summonerText
            // 
            this.summonerText.Location = new System.Drawing.Point(680, 341);
            this.summonerText.Name = "summonerText";
            this.summonerText.Size = new System.Drawing.Size(218, 20);
            this.summonerText.TabIndex = 1;
            this.summonerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(734, 364);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(131, 23);
            this.lookupButton.TabIndex = 2;
            this.lookupButton.Text = "Lookup Summoner";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.lookup_Click);
            // 
            // lobbyGrid
            // 
            this.lobbyGrid.AllowUserToAddRows = false;
            this.lobbyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lobbyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SName,
            this.Rank,
            this.Weight});
            this.lobbyGrid.Location = new System.Drawing.Point(12, 28);
            this.lobbyGrid.Name = "lobbyGrid";
            this.lobbyGrid.ReadOnly = true;
            this.lobbyGrid.Size = new System.Drawing.Size(343, 333);
            this.lobbyGrid.TabIndex = 4;
            // 
            // SName
            // 
            this.SName.HeaderText = "Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // lobbyLabel
            // 
            this.lobbyLabel.AutoSize = true;
            this.lobbyLabel.Location = new System.Drawing.Point(12, 12);
            this.lobbyLabel.Name = "lobbyLabel";
            this.lobbyLabel.Size = new System.Drawing.Size(36, 13);
            this.lobbyLabel.TabIndex = 5;
            this.lobbyLabel.Text = "Lobby";
            // 
            // team1Grid
            // 
            this.team1Grid.AllowUserToAddRows = false;
            this.team1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.team1Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Members});
            this.team1Grid.Location = new System.Drawing.Point(361, 28);
            this.team1Grid.Name = "team1Grid";
            this.team1Grid.ReadOnly = true;
            this.team1Grid.Size = new System.Drawing.Size(143, 333);
            this.team1Grid.TabIndex = 6;
            // 
            // Members
            // 
            this.Members.HeaderText = "Name";
            this.Members.Name = "Members";
            this.Members.ReadOnly = true;
            // 
            // team2Grid
            // 
            this.team2Grid.AllowUserToAddRows = false;
            this.team2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.team2Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.team2Grid.Location = new System.Drawing.Point(510, 28);
            this.team2Grid.Name = "team2Grid";
            this.team2Grid.ReadOnly = true;
            this.team2Grid.Size = new System.Drawing.Size(143, 333);
            this.team2Grid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Location = new System.Drawing.Point(358, 12);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(43, 13);
            this.team1Label.TabIndex = 8;
            this.team1Label.Text = "Team 1";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Location = new System.Drawing.Point(507, 12);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(43, 13);
            this.team2Label.TabIndex = 9;
            this.team2Label.Text = "Team 2";
            // 
            // champPicture
            // 
            this.champPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.champPicture.Location = new System.Drawing.Point(659, 28);
            this.champPicture.Name = "champPicture";
            this.champPicture.Size = new System.Drawing.Size(160, 135);
            this.champPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.champPicture.TabIndex = 10;
            this.champPicture.TabStop = false;
            // 
            // rankPicture
            // 
            this.rankPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rankPicture.Location = new System.Drawing.Point(835, 28);
            this.rankPicture.Name = "rankPicture";
            this.rankPicture.Size = new System.Drawing.Size(160, 135);
            this.rankPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rankPicture.TabIndex = 11;
            this.rankPicture.TabStop = false;
            // 
            // mpcLabel
            // 
            this.mpcLabel.AutoSize = true;
            this.mpcLabel.Location = new System.Drawing.Point(656, 12);
            this.mpcLabel.Name = "mpcLabel";
            this.mpcLabel.Size = new System.Drawing.Size(101, 13);
            this.mpcLabel.TabIndex = 12;
            this.mpcLabel.Text = "Most Played Champ";
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(832, 12);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(33, 13);
            this.rankLabel.TabIndex = 13;
            this.rankLabel.Text = "Rank";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(777, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // summonerLabel
            // 
            this.summonerLabel.AutoSize = true;
            this.summonerLabel.Location = new System.Drawing.Point(747, 325);
            this.summonerLabel.Name = "summonerLabel";
            this.summonerLabel.Size = new System.Drawing.Size(88, 13);
            this.summonerLabel.TabIndex = 15;
            this.summonerLabel.Text = "Summoner Name";
            // 
            // addToLobbyButton
            // 
            this.addToLobbyButton.Location = new System.Drawing.Point(777, 195);
            this.addToLobbyButton.Name = "addToLobbyButton";
            this.addToLobbyButton.Size = new System.Drawing.Size(100, 23);
            this.addToLobbyButton.TabIndex = 16;
            this.addToLobbyButton.Text = "Add To Lobby";
            this.addToLobbyButton.UseVisualStyleBackColor = true;
            this.addToLobbyButton.Click += new System.EventHandler(this.addToLobbyButton_Click);
            // 
            // lobbyClearButton
            // 
            this.lobbyClearButton.Location = new System.Drawing.Point(15, 367);
            this.lobbyClearButton.Name = "lobbyClearButton";
            this.lobbyClearButton.Size = new System.Drawing.Size(75, 23);
            this.lobbyClearButton.TabIndex = 17;
            this.lobbyClearButton.Text = "Clear Lobby";
            this.lobbyClearButton.UseVisualStyleBackColor = true;
            this.lobbyClearButton.Click += new System.EventHandler(this.lobbyClearButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(96, 367);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 23);
            this.generateButton.TabIndex = 18;
            this.generateButton.Text = "Generate Team";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // regionList
            // 
            this.regionList.FormattingEnabled = true;
            this.regionList.Items.AddRange(new object[] {
            "NA",
            "EUNE",
            "EUW",
            "GLOBAL",
            "KR",
            "LAN",
            "LAS",
            "NA",
            "OCE",
            "RU",
            "TR"});
            this.regionList.Location = new System.Drawing.Point(905, 341);
            this.regionList.Name = "regionList";
            this.regionList.Size = new System.Drawing.Size(63, 21);
            this.regionList.TabIndex = 19;
            this.regionList.SelectedIndexChanged += new System.EventHandler(this.region_SelectedIndexChanged);
            // 
            // unrankedLabel
            // 
            this.unrankedLabel.AutoSize = true;
            this.unrankedLabel.Location = new System.Drawing.Point(891, 87);
            this.unrankedLabel.Name = "unrankedLabel";
            this.unrankedLabel.Size = new System.Drawing.Size(54, 13);
            this.unrankedLabel.TabIndex = 20;
            this.unrankedLabel.Text = "Unranked";
            this.unrankedLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(904, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Region";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(363, 364);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.teamOneScoreLabel.TabIndex = 22;
            this.teamOneScoreLabel.Text = "Score:";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(507, 364);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(38, 13);
            this.teamTwoScoreLabel.TabIndex = 23;
            this.teamTwoScoreLabel.Text = "Score:";
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(12, 406);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(503, 20);
            this.apiKey.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "APIKey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apiKey);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unrankedLabel);
            this.Controls.Add(this.regionList);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.lobbyClearButton);
            this.Controls.Add(this.addToLobbyButton);
            this.Controls.Add(this.summonerLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.mpcLabel);
            this.Controls.Add(this.rankPicture);
            this.Controls.Add(this.champPicture);
            this.Controls.Add(this.team2Label);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.team2Grid);
            this.Controls.Add(this.team1Grid);
            this.Controls.Add(this.lobbyLabel);
            this.Controls.Add(this.lobbyGrid);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.summonerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inhouse";
            ((System.ComponentModel.ISupportInitialize)(this.lobbyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox summonerText;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.DataGridView lobbyGrid;
        private System.Windows.Forms.Label lobbyLabel;
        private System.Windows.Forms.DataGridView team1Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Members;
        private System.Windows.Forms.DataGridView team2Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.PictureBox champPicture;
        private System.Windows.Forms.PictureBox rankPicture;
        private System.Windows.Forms.Label mpcLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.Label summonerLabel;
        private System.Windows.Forms.Button addToLobbyButton;
        private System.Windows.Forms.Button lobbyClearButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ComboBox regionList;
        private System.Windows.Forms.Label unrankedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.Label label2;
    }
}

