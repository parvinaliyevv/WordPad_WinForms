
namespace homework_2
{
    partial class WordPad
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
            this.content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.leftAlignmentButton = new System.Windows.Forms.Button();
            this.centerAlignmentButton = new System.Windows.Forms.Button();
            this.rightAlignmentButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 77);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1138, 482);
            this.content.TabIndex = 0;
            this.content.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(364, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "FontStyle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(486, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(639, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Color";
            // 
            // fontBox
            // 
            this.fontBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Location = new System.Drawing.Point(56, 37);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(121, 23);
            this.fontBox.TabIndex = 2;
            this.fontBox.SelectedIndexChanged += new System.EventHandler(this.fontBox_SelectedIndexChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(209, 37);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(121, 23);
            this.sizeBox.TabIndex = 2;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.fontBox_SelectedIndexChanged);
            // 
            // leftAlignmentButton
            // 
            this.leftAlignmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftAlignmentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftAlignmentButton.Location = new System.Drawing.Point(479, 37);
            this.leftAlignmentButton.Name = "leftAlignmentButton";
            this.leftAlignmentButton.Size = new System.Drawing.Size(28, 23);
            this.leftAlignmentButton.TabIndex = 3;
            this.leftAlignmentButton.Text = "L";
            this.leftAlignmentButton.UseVisualStyleBackColor = true;
            this.leftAlignmentButton.Click += new System.EventHandler(this.leftAlignmentButton_Click);
            // 
            // centerAlignmentButton
            // 
            this.centerAlignmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.centerAlignmentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.centerAlignmentButton.Location = new System.Drawing.Point(513, 37);
            this.centerAlignmentButton.Name = "centerAlignmentButton";
            this.centerAlignmentButton.Size = new System.Drawing.Size(28, 23);
            this.centerAlignmentButton.TabIndex = 3;
            this.centerAlignmentButton.Text = "C";
            this.centerAlignmentButton.UseVisualStyleBackColor = true;
            this.centerAlignmentButton.Click += new System.EventHandler(this.centerAlignmentButton_Click);
            // 
            // rightAlignmentButton
            // 
            this.rightAlignmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightAlignmentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightAlignmentButton.Location = new System.Drawing.Point(547, 37);
            this.rightAlignmentButton.Name = "rightAlignmentButton";
            this.rightAlignmentButton.Size = new System.Drawing.Size(28, 23);
            this.rightAlignmentButton.TabIndex = 3;
            this.rightAlignmentButton.Text = "R";
            this.rightAlignmentButton.UseVisualStyleBackColor = true;
            this.rightAlignmentButton.Click += new System.EventHandler(this.rightAlignmentButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(603, 37);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 23);
            this.colorBox.TabIndex = 2;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorBox_SelectedIndexChanged);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filenameTextBox.Location = new System.Drawing.Point(782, 9);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(331, 27);
            this.filenameTextBox.TabIndex = 4;
            // 
            // loadButton
            // 
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(782, 44);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(159, 27);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(963, 44);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 27);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(352, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(28, 23);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "B";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(386, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(28, 23);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "U";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(420, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(28, 23);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "/";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // WordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 571);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.rightAlignmentButton);
            this.Controls.Add(this.centerAlignmentButton);
            this.Controls.Add(this.leftAlignmentButton);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content);
            this.MaximumSize = new System.Drawing.Size(1178, 610);
            this.MinimumSize = new System.Drawing.Size(1178, 610);
            this.Name = "WordPad";
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Button leftAlignmentButton;
        private System.Windows.Forms.Button centerAlignmentButton;
        private System.Windows.Forms.Button rightAlignmentButton;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

