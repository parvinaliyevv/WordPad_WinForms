using System;
using System.Collections.Generic;
using System.Windows.Forms;
using homework_1.Views.UserControls;

namespace homework_1.Views.Forms
{
    public partial class Stadium : Form
    {
        private string _format = null;

        public Stadium(KeyValuePair<string, string> country, List<PlayerBoxControl> playerBoxControls, string format)
        {
            InitializeComponent();

            _format = format;
            countryName.Text = country.Key;
            countryFlag.LoadAsync(country.Value);

            for (int i = 0; i < Main.playerCount; i++) pictureBox1.Controls.Add(new PlayerControl(playerBoxControls[i].nameTextBox.Text));
        }

        private void Stadium_Load(object sender, EventArgs e)
        {
            int posX, posY;

            if (_format == "4-4-2")
            {
                posX = 100;
                posY = 50;

                pictureBox1.Controls[0].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[1].Location = new System.Drawing.Point(posX, posY);


                posX = 5;
                posY += 170;


                pictureBox1.Controls[2].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[3].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[4].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[5].Location = new System.Drawing.Point(posX, posY);


                posX = 5;
                posY += 140;


                pictureBox1.Controls[6].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[7].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[8].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[9].Location = new System.Drawing.Point(posX, posY);
            }
            else if (_format == "4-2-4")
            {
                posX = 5;
                posY = 50;

                pictureBox1.Controls[0].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[1].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[2].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[3].Location = new System.Drawing.Point(posX, posY);


                posX = 100;
                posY += 170;


                pictureBox1.Controls[4].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[5].Location = new System.Drawing.Point(posX, posY);


                posX = 5;
                posY += 140;


                pictureBox1.Controls[6].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[7].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[8].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[9].Location = new System.Drawing.Point(posX, posY);
            }
            else
            {
                posX = 50;
                posY = 50;

                pictureBox1.Controls[0].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[1].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[2].Location = new System.Drawing.Point(posX, posY);


                posX = 50;
                posY += 170;


                pictureBox1.Controls[3].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[4].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[5].Location = new System.Drawing.Point(posX, posY);


                posX = 5;
                posY += 140;


                pictureBox1.Controls[6].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[7].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[8].Location = new System.Drawing.Point(posX, posY);
                posX += 90;
                pictureBox1.Controls[9].Location = new System.Drawing.Point(posX, posY);
            }

            posX = 143;
            posY = 440;

            pictureBox1.Controls[10].Location = new System.Drawing.Point(143, 440);
        }
    }
}
