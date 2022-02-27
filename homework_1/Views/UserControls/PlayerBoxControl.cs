using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_1.Views.UserControls
{
    public partial class PlayerBoxControl : UserControl
    {
        public PlayerBoxControl() => InitializeComponent();

        private void PlayerBoxControl_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = "PlayerControl";
            numberTextBox.Text = new Random().Next(1, 100).ToString();
        }
    }
}
