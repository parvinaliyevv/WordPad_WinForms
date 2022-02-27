using System;
using System.Windows.Forms;

namespace homework_1.Views.UserControls
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }
    }
}
