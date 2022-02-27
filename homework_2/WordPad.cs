using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace homework_2
{
    public partial class WordPad : Form
    {
        public static FontStyle fontStyle = FontStyle.Regular;
     
        public WordPad() => InitializeComponent();

        private void Application_Load(object sender, EventArgs e)
        {
            
            fontBox.Items.AddRange((from i in FontFamily.Families select i.Name).ToArray());
            colorBox.Items.AddRange((from i in typeof(Color).GetProperties() select i.Name).ToArray());

            for (int i = 2; i < 100; i += 2) sizeBox.Items.Add(i);

            sizeBox.SelectedIndex = 5;
            fontBox.SelectedIndex = 7;
            colorBox.SelectedIndex = 8;

            content.Font = new Font(new FontFamily(fontBox.SelectedItem.ToString()), Convert.ToSingle(sizeBox.SelectedItem));
        }

        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(content.SelectedText)) content.Font = new Font(new FontFamily((fontBox.SelectedItem is not null) ? fontBox.SelectedItem.ToString() : "Arial"), Convert.ToSingle(sizeBox.SelectedItem));
            else content.SelectionFont = new Font(new FontFamily(fontBox.SelectedItem.ToString()), Convert.ToSingle(sizeBox.SelectedItem));
        }
        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(content.SelectedText)) content.ForeColor = Color.FromName(colorBox.Text);
            else content.SelectionColor = Color.FromName(colorBox.Text);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using var stream = new StreamReader(filenameTextBox.Text);
                content.Text = stream.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using var stream = new FileStream(filenameTextBox.Text, FileMode.Create);
            stream.Write(Encoding.Default.GetBytes(content.Text));
        }

        private void leftAlignmentButton_Click(object sender, EventArgs e) => content.SelectionAlignment = HorizontalAlignment.Left;
        private void rightAlignmentButton_Click(object sender, EventArgs e) => content.SelectionAlignment = HorizontalAlignment.Right;
        private void centerAlignmentButton_Click(object sender, EventArgs e) => content.SelectionAlignment = HorizontalAlignment.Center;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (!content.SelectionFont.Bold) fontStyle |= FontStyle.Bold;
                else fontStyle -= FontStyle.Bold;

                ChangeFontStyle();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (!content.SelectionFont.Underline) fontStyle |= FontStyle.Underline;
                else fontStyle -= FontStyle.Underline;

                ChangeFontStyle();
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                if (!content.SelectionFont.Italic) fontStyle |= FontStyle.Italic;
                else fontStyle -= FontStyle.Italic;

                ChangeFontStyle();
            }
        }

        private void ChangeFontStyle()
        {
            if (string.IsNullOrWhiteSpace(content.SelectedText)) content.Font = new Font(content.SelectionFont, fontStyle);
            else content.SelectionFont = new Font(content.SelectionFont, fontStyle);
        }
    }
}
