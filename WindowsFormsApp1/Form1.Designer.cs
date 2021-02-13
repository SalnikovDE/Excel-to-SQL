
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExcelLoadTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LoadDataChooseFileButton = new System.Windows.Forms.Button();
            this.ChooseTableButton = new System.Windows.Forms.Button();
            this.SaveFirstButton = new System.Windows.Forms.Button();
            this.SaveSecondButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenExcelDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel load data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SQL to Excel save file 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL to Excel save file 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Table Name";
            this.label4.UseMnemonic = false;
            // 
            // ExcelLoadTextBox
            // 
            this.ExcelLoadTextBox.Location = new System.Drawing.Point(98, 62);
            this.ExcelLoadTextBox.Name = "ExcelLoadTextBox";
            this.ExcelLoadTextBox.Size = new System.Drawing.Size(323, 20);
            this.ExcelLoadTextBox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 20);
            this.textBox4.TabIndex = 7;
            // 
            // LoadDataChooseFileButton
            // 
            this.LoadDataChooseFileButton.Location = new System.Drawing.Point(428, 62);
            this.LoadDataChooseFileButton.Name = "LoadDataChooseFileButton";
            this.LoadDataChooseFileButton.Size = new System.Drawing.Size(75, 20);
            this.LoadDataChooseFileButton.TabIndex = 8;
            this.LoadDataChooseFileButton.Text = "Open";
            this.LoadDataChooseFileButton.UseVisualStyleBackColor = true;
            this.LoadDataChooseFileButton.Click += new System.EventHandler(this.LoadDataChooseFileButton_Click);
            // 
            // ChooseTableButton
            // 
            this.ChooseTableButton.Location = new System.Drawing.Point(428, 90);
            this.ChooseTableButton.Name = "ChooseTableButton";
            this.ChooseTableButton.Size = new System.Drawing.Size(75, 21);
            this.ChooseTableButton.TabIndex = 9;
            this.ChooseTableButton.Text = "Choose";
            this.ChooseTableButton.UseVisualStyleBackColor = true;
            // 
            // SaveFirstButton
            // 
            this.SaveFirstButton.Location = new System.Drawing.Point(428, 148);
            this.SaveFirstButton.Name = "SaveFirstButton";
            this.SaveFirstButton.Size = new System.Drawing.Size(75, 20);
            this.SaveFirstButton.TabIndex = 10;
            this.SaveFirstButton.Text = "Open";
            this.SaveFirstButton.UseVisualStyleBackColor = true;
            // 
            // SaveSecondButton
            // 
            this.SaveSecondButton.Location = new System.Drawing.Point(428, 179);
            this.SaveSecondButton.Name = "SaveSecondButton";
            this.SaveSecondButton.Size = new System.Drawing.Size(75, 20);
            this.SaveSecondButton.TabIndex = 11;
            this.SaveSecondButton.Text = "Open";
            this.SaveSecondButton.UseVisualStyleBackColor = true;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(15, 248);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(142, 59);
            this.LoadDataButton.TabIndex = 12;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.load_data_button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 59);
            this.button2.TabIndex = 13;
            this.button2.Text = "Make First SQL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 59);
            this.button3.TabIndex = 14;
            this.button3.Text = "Make Second SQL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(133, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Excel to PostgreSQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.SaveSecondButton);
            this.Controls.Add(this.SaveFirstButton);
            this.Controls.Add(this.ChooseTableButton);
            this.Controls.Add(this.LoadDataChooseFileButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ExcelLoadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExcelLoadTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button LoadDataChooseFileButton;
        private System.Windows.Forms.Button ChooseTableButton;
        private System.Windows.Forms.Button SaveFirstButton;
        private System.Windows.Forms.Button SaveSecondButton;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog OpenExcelDialog;
    }
}

