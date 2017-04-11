namespace _11_25_13_ISPROG1LoopsLongQuiz
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(83, 30);
            this.b1.TabIndex = 0;
            this.b1.Text = "Multiples of 12";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(101, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(204, 30);
            this.b2.TabIndex = 1;
            this.b2.Text = "Double Every Number from 1 to 256";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(12, 190);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(83, 30);
            this.b3.TabIndex = 2;
            this.b3.Text = "200 to 100";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(101, 190);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(204, 30);
            this.b4.TabIndex = 3;
            this.b4.Text = "Average of all integers from 1 to 100";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(12, 48);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(83, 134);
            this.lb1.TabIndex = 4;
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(12, 225);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(83, 134);
            this.lb3.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(101, 50);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(204, 134);
            this.lb2.TabIndex = 6;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(101, 226);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(89, 20);
            this.tb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 371);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "f";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.TextBox tb;
    }
}

