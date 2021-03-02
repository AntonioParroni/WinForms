namespace NewForm
{
    partial class Form2
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
            this.btnSearchF2 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchF2
            // 
            this.btnSearchF2.Location = new System.Drawing.Point(266, 289);
            this.btnSearchF2.Name = "btnSearchF2";
            this.btnSearchF2.Size = new System.Drawing.Size(75, 23);
            this.btnSearchF2.TabIndex = 1;
            this.btnSearchF2.Text = "Search";
            this.btnSearchF2.UseMnemonic = false;
            this.btnSearchF2.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(329, 199);
            this.listBox.TabIndex = 2;
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(12, 292);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(248, 20);
            this.textBoxF2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(74, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the desired mask like <<*.doc>>";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSearchF2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Frame";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSearchF2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Label label1;
    }
}