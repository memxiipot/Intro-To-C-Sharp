namespace Point_Rectangle_Intersection_Test
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
            this.tx = new System.Windows.Forms.TextBox();
            this.ty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lOut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "X-Coordinate";
            // 
            // tx
            // 
            this.tx.Location = new System.Drawing.Point(166, 48);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(89, 29);
            this.tx.TabIndex = 2;
            // 
            // ty
            // 
            this.ty.Location = new System.Drawing.Point(166, 83);
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(89, 29);
            this.ty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y-Coordinate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output:";
            // 
            // lOut
            // 
            this.lOut.BackColor = System.Drawing.Color.White;
            this.lOut.Location = new System.Drawing.Point(90, 138);
            this.lOut.Name = "lOut";
            this.lOut.Size = new System.Drawing.Size(165, 24);
            this.lOut.TabIndex = 6;
            this.lOut.Text = "NO OUTPUT";
            this.lOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Process Point";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.TextBox ty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lOut;
        private System.Windows.Forms.Button button1;
    }
}

