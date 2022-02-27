namespace homework_1.Views.Forms
{
    partial class Stadium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stadium));
            this.countryFlag = new System.Windows.Forms.PictureBox();
            this.countryName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countryFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // countryFlag
            // 
            this.countryFlag.Location = new System.Drawing.Point(246, 5);
            this.countryFlag.Name = "countryFlag";
            this.countryFlag.Size = new System.Drawing.Size(103, 50);
            this.countryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.countryFlag.TabIndex = 0;
            this.countryFlag.TabStop = false;
            // 
            // countryName
            // 
            this.countryName.AutoSize = true;
            this.countryName.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryName.Location = new System.Drawing.Point(12, 19);
            this.countryName.Name = "countryName";
            this.countryName.Size = new System.Drawing.Size(79, 19);
            this.countryName.TabIndex = 1;
            this.countryName.Text = "Country";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::homework_1.Properties.Resources.stadium;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countryName);
            this.Controls.Add(this.countryFlag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stadium";
            this.Text = "Stadium";
            this.Load += new System.EventHandler(this.Stadium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox countryFlag;
        private System.Windows.Forms.Label countryName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}