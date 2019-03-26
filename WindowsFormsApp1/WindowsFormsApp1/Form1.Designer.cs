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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.E95 = new System.Windows.Forms.Label();
            this.Diesel = new System.Windows.Forms.Label();
            this.E98 = new System.Windows.Forms.Label();
            this.tilaa = new System.Windows.Forms.Button();
            this.suljebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polttoainetankit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "95";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "98";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "diesel";
            // 
            // E95
            // 
            this.E95.AutoSize = true;
            this.E95.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E95.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.E95.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E95.Location = new System.Drawing.Point(71, 245);
            this.E95.MinimumSize = new System.Drawing.Size(70, 0);
            this.E95.Name = "E95";
            this.E95.Size = new System.Drawing.Size(70, 19);
            this.E95.TabIndex = 5;
            // 
            // Diesel
            // 
            this.Diesel.AutoSize = true;
            this.Diesel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Diesel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diesel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Diesel.Location = new System.Drawing.Point(369, 245);
            this.Diesel.MinimumSize = new System.Drawing.Size(70, 0);
            this.Diesel.Name = "Diesel";
            this.Diesel.Size = new System.Drawing.Size(70, 19);
            this.Diesel.TabIndex = 6;
            // 
            // E98
            // 
            this.E98.AutoSize = true;
            this.E98.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.E98.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.E98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.E98.Location = new System.Drawing.Point(221, 245);
            this.E98.MinimumSize = new System.Drawing.Size(70, 0);
            this.E98.Name = "E98";
            this.E98.Size = new System.Drawing.Size(70, 19);
            this.E98.TabIndex = 7;
            // 
            // tilaa
            // 
            this.tilaa.Location = new System.Drawing.Point(71, 334);
            this.tilaa.Name = "tilaa";
            this.tilaa.Size = new System.Drawing.Size(75, 23);
            this.tilaa.TabIndex = 8;
            this.tilaa.Text = "Tilaus";
            this.tilaa.UseVisualStyleBackColor = true;
            this.tilaa.Click += new System.EventHandler(this.tilaa_Click);
            // 
            // suljebutton
            // 
            this.suljebutton.Location = new System.Drawing.Point(369, 334);
            this.suljebutton.Name = "suljebutton";
            this.suljebutton.Size = new System.Drawing.Size(75, 23);
            this.suljebutton.TabIndex = 9;
            this.suljebutton.Text = "Sulje";
            this.suljebutton.UseVisualStyleBackColor = true;
            this.suljebutton.Click += new System.EventHandler(this.suljebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 245);
            this.label6.MinimumSize = new System.Drawing.Size(20, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 247);
            this.label7.MinimumSize = new System.Drawing.Size(20, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 247);
            this.label8.MinimumSize = new System.Drawing.Size(20, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(221, 183);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 14;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(369, 183);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "5000 litraa max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.suljebutton);
            this.Controls.Add(this.tilaa);
            this.Controls.Add(this.E98);
            this.Controls.Add(this.Diesel);
            this.Controls.Add(this.E95);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "bensiinitankit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label E95;
        private System.Windows.Forms.Label Diesel;
        private System.Windows.Forms.Label E98;
        private System.Windows.Forms.Button tilaa;
        private System.Windows.Forms.Button suljebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label2;
    }
}

