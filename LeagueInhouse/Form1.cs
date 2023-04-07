using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RiotSharp;
using RiotSharp.Endpoints.LeagueEndpoint.Enums;

namespace LeagueInhouse
{
    public partial class Form1 : Form
    {

        private RiotApi api;
        private string key;
        private Lobby lobby;
        private Summoner currentSummoner;
        private RiotSharp.Misc.Region region;

        public Form1()
        {
            InitializeComponent();
            api = RiotApi.GetInstance("YOUR_API_KEY", 200, 500);
            lobby = new Lobby();
        }

        private void newLobbyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lookup_Click(object sender, EventArgs e)
        {
            if (key == null)
            {
                key = apiKey.Text;
                api = RiotApi.GetInstance(key, 200, 500);
            }
            if (summonerText.Text.Length != 0)
            {
                var player = (dynamic) null;

                try
                {
                    player = api.Summoner.GetSummonerByNameAsync(region, summonerText.Text).Result;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
                if (player != null)
                {
                    if (regionList.SelectedIndex >= 0)
                    {
                        string tier = LeagueInformation.GetTier(region, player.Id, api);
                        string rank = LeagueInformation.GetRank(region, player.Id, api);
                        int weight = LeagueInformation.CalculateWeight(rank, tier);
                        if (weight == 0)
                        {
                            tier = "UNRANKED";
                        }
                        currentSummoner = new Summoner(player.Id, player.Name, tier, rank, region, weight);
                        UpdateChamp();
                        UpdateRank(tier);
                    } else
                    {
                        MessageBox.Show("You must select a region.");
                    }
                } else
                {
                    MessageBox.Show("Summoner does not exist.");
                }
            } else
            {
                MessageBox.Show("You must enter a summoner name.");
            }
        }

        private void UpdateChamp()
        {
            textBox3.Text = currentSummoner.GetName();
            string name = LeagueInformation.GetMostPlayedChampion(region, currentSummoner.GetId(), api);
            string newName = name.Replace(" ", "");
            Console.WriteLine(newName);
            champPicture.LoadAsync(@"http://ddragon.leagueoflegends.com/cdn/12.8.1/img/champion/" + newName + ".png");
        }

        private void UpdateRank(string tier)
        {
            if (currentSummoner.GetRank() == null && currentSummoner.GetTier() == null)
            {
                unrankedLabel.Visible = true;
                currentSummoner.SetTier("UNRANKED");
            }
            else
            {
                if (currentSummoner.GetRank() == null)
                {
                    unrankedLabel.Visible = true;
                }
                else
                {
                    unrankedLabel.Visible = false;
                    rankPicture.Image = GetEmblem(tier);
                }
            }
        }

        private Bitmap GetEmblem(string emb)
        {
            Bitmap image = null;

            switch (emb)
            {
                case "BRONZE":
                    image = Properties.Resources.Emblem_Bronze;
                    break;
                case "IRON":
                    image = Properties.Resources.Emblem_Iron;
                    break;
                case "SILVER":
                    image = Properties.Resources.Emblem_Silver;
                    break;
                case "GOLD":
                    image = Properties.Resources.Emblem_Gold;
                    break;
                case "PLATINUM":
                    image = Properties.Resources.Emblem_Platinum;
                    break;
                case "DIAMOND":
                    image = Properties.Resources.Emblem_Diamond;
                    break;
                case "MASTER":
                    image = Properties.Resources.Emblem_Master;
                    break;
                case "GRANDMASTER":
                    image = Properties.Resources.Emblem_Grandmaster;
                    break;
                case "CHALLENGER":
                    image = Properties.Resources.Emblem_Challenger;
                    break;
            }
            return image;
        }

        private void region_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (RiotSharp.Misc.Region regions in Enum.GetValues(typeof(RiotSharp.Misc.Region)))
            {
                if (regions.ToString().ToUpper().Equals(regionList.SelectedItem.ToString()))
                {
                    region = regions;
                    break;
                }
            }
        }

        private void addToLobbyButton_Click(object sender, EventArgs e)
        {
            if (lobby.GetSummoners().Count < 10)
            {
                if (currentSummoner != null)
                {

                    if (lobby.GetSummoners().Contains(currentSummoner))
                    {
                        MessageBox.Show("This summoner has already been added.");
                        return;
                    }

                    lobby.AddSummoner(currentSummoner);

                    string[] row = { currentSummoner.GetName(), currentSummoner.GetTier(), currentSummoner.GetWeight().ToString() };

                    lobbyGrid.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("You must lookup a summoner.");
                }
            } else
            {
                MessageBox.Show("You have added 10 summoners already.");
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (lobby.LobbySize() == 10)
            {
                List<int> nums = new List<int>();

                int teamOneScore = 0;
                int teamTwoScore = 0;

                int i = 0; 

                List<KeyValuePair<int, Summoner>> map = new List<KeyValuePair<int, Summoner>>(); 

                foreach (Summoner summoner in lobby.GetSummoners())
                {
                    map.Add(new KeyValuePair<int, Summoner>(summoner.GetWeight(), summoner));
                }

                map = map.OrderBy(x => x.Key).ToList();

                foreach (KeyValuePair<int, Summoner> pair in map)
                {
                    if (i % 2 == 0)
                    {
                        lobby.AddTeamOne(pair.Value);
                        teamOneScore += pair.Key;
                    } else
                    {
                        lobby.AddTeamTwo(pair.Value);
                        teamTwoScore += pair.Key;
                    }
                    i++;
                }

                foreach(Summoner summoner in lobby.GetTeamOne())
                {
                    string[] row = { summoner.GetName() };
                    team1Grid.Rows.Add(row);
                }

                teamOneScoreLabel.Text = "Score: " + teamOneScore;

                foreach (Summoner summoner in lobby.GetTeamTwo())
                {
                    string[] row = { summoner.GetName() };
                    team2Grid.Rows.Add(row);
                }

                teamTwoScoreLabel.Text = "Score: " + teamTwoScore;

            } else
            {
                MessageBox.Show("You must have atleast 10 summoners added.");
            }
        }

        private void lobbyClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
