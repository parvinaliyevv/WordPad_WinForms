namespace homework_1.Views.UserControls
{
    partial class PlayerBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // positionTextBox
            // 
            this.positionTextBox.Enabled = false;
            this.positionTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionTextBox.Location = new System.Drawing.Point(1, 11);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(121, 23);
            this.positionTextBox.TabIndex = 0;
            this.positionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTextBox.Location = new System.Drawing.Point(180, 11);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(121, 23);
            this.numberTextBox.TabIndex = 1;
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(359, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // PlayerBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Name = "PlayerBoxControl";
            this.Size = new System.Drawing.Size(480, 47);
            this.Load += new System.EventHandler(this.PlayerBoxControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox positionTextBox;
        public System.Windows.Forms.TextBox numberTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
    }
}
