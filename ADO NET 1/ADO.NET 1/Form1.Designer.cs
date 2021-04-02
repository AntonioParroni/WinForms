using System.Drawing;

namespace ADO.NET_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConnectedTrueBox = new System.Windows.Forms.TextBox();
            this.ConnectedFalseBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 94);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(160, 25);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(59, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(152, 13);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Please Insert Database Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectedTrueBox
            // 
            this.ConnectedTrueBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectedTrueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectedTrueBox.ForeColor = System.Drawing.Color.Green;
            this.ConnectedTrueBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConnectedTrueBox.Location = new System.Drawing.Point(90, 256);
            this.ConnectedTrueBox.Name = "ConnectedTrueBox";
            this.ConnectedTrueBox.ReadOnly = true;
            this.ConnectedTrueBox.Size = new System.Drawing.Size(90, 13);
            this.ConnectedTrueBox.TabIndex = 4;
            this.ConnectedTrueBox.Text = "Connected!";
            this.ConnectedTrueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectedFalseBox
            // 
            this.ConnectedFalseBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectedFalseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectedFalseBox.ForeColor = System.Drawing.Color.Red;
            this.ConnectedFalseBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ConnectedFalseBox.Location = new System.Drawing.Point(59, 125);
            this.ConnectedFalseBox.Name = "ConnectedFalseBox";
            this.ConnectedFalseBox.ReadOnly = true;
            this.ConnectedFalseBox.Size = new System.Drawing.Size(152, 13);
            this.ConnectedFalseBox.TabIndex = 5;
            this.ConnectedFalseBox.Text = "Invalid Input!";
            this.ConnectedFalseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(384, 409);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox2.Location = new System.Drawing.Point(59, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(152, 13);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Select Table";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 428);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(665, 22);
            this.statusBar1.TabIndex = 9;
            this.statusBar1.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConnectedFalseBox);
            this.Controls.Add(this.ConnectedTrueBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "DataBase Browser";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.StatusBar statusBar1;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox ConnectedTrueBox;
        private System.Windows.Forms.TextBox ConnectedFalseBox;

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}