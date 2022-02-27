using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using homework_1.Views.Forms;
using homework_1.Views.UserControls;
using homework_1.Models;

namespace homework_1
{
    public partial class Main : Form
    {
        public static byte playerCount = 11;
        private string[] _positions = new string[4] { "F", "MD", "DD", "GK" };
        private List<PlayerBoxControl> _playerBoxControls = new();
        private Dictionary<string, string> _countries = new();

        public Main()
        {
            InitializeComponent();

            if (!File.Exists("countries.json"))
            {
                var parser = new System.Net.WebClient();
                var countriesInfo = parser.DownloadData("http://www.geognos.com/api/en/countries/info/all.json");
                File.WriteAllText("countries.json", System.Text.Encoding.Default.GetString(countriesInfo));
            }

            CountryParse parseData = Newtonsoft.Json.JsonConvert.DeserializeObject<CountryParse>(File.ReadAllText("countries.json"));

            foreach (var item in parseData.Results.Values)
                _countries.Add(item.Name, String.Format("http://www.geognos.com/api/en/countries/flag/{0}.png", item.CountryCodes.iso2));

            countries.DataSource = _countries.Keys.ToArray();
            countries.SelectedIndex = countries.Items.IndexOf("Azerbaijan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formations.Items.AddRange(new string[] { "4-3-3", "4-4-2", "4-2-4" });

            int posX = 12, posY = 90;

            for (int i = 0; i < playerCount; i++)
            {
                var playerBoxControl = new PlayerBoxControl()
                {
                    Location = new System.Drawing.Point(posX, posY)
                };

                posY += 40;

                Controls.Add(playerBoxControl);
                _playerBoxControls.Add(playerBoxControl);
            }

            formations.SelectedIndex = 0;
        }

        private void formations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var format = new List<string>(formations.SelectedItem.ToString().Split('-'));
            format.Reverse();
            format.Add("1");

            for (int i = default, index = default; i < format.Count; i++)
            {
                for (int j = default; j < Convert.ToByte(format[i]); j++)
                {
                    foreach (TextBox item in _playerBoxControls[index++].Controls)
                        if (item.Name == "positionTextBox") item.Text = _positions[i];
                }
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            foreach (PlayerBoxControl playerBoxControl in _playerBoxControls)
            {

                // Empty validation

                if (string.IsNullOrWhiteSpace(playerBoxControl.nameTextBox.Text) || string.IsNullOrWhiteSpace(playerBoxControl.numberTextBox.Text))
                {
                    MessageBox.Show($"Fill in all the fields!", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // NumberTextBox validation

                int number = default, count = default;

                try
                {
                    number = Convert.ToInt16(playerBoxControl.numberTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show($"You can only enter a integer!\nPlayer Name: {playerBoxControl.nameTextBox.Text}", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (number < 1 || number > 99)
                {
                    MessageBox.Show($"Single number in the range (1 - 100)!\nPlayer Name: {playerBoxControl.nameTextBox.Text}", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (PlayerBoxControl item in _playerBoxControls)
                {
                    if (item.numberTextBox.Text == playerBoxControl.numberTextBox.Text)
                    {
                        if (count == 1)
                        {
                            MessageBox.Show($"A character with this number already exists!\nPlayer Name: {playerBoxControl.nameTextBox.Text}", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        count++;
                    }
                }


                // NameTextBox validation

                foreach (var item in playerBoxControl.nameTextBox.Text)
                {
                    if (char.IsDigit(item))
                    {
                        MessageBox.Show("The name cannot contain an integer!", "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            KeyValuePair<string, string> data = default;

            foreach (KeyValuePair<string, string> item in _countries)
            {
                if (item.Key == countries.SelectedItem.ToString())
                {
                    data = item;
                    break;
                }
            }

            var stadium = new Stadium(data, _playerBoxControls, formations.SelectedItem.ToString());
            this.Hide();
            stadium.ShowDialog();

            stadium.Dispose();
            this.Dispose();
        }
    }
}
