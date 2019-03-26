namespace WindowsFormsApp1
{
    partial class TilausLomake
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
            this.tilausmaara95 = new System.Windows.Forms.TextBox();
            this.tilaa95 = new System.Windows.Forms.Button();
            this.tilaa98 = new System.Windows.Forms.Button();
            this.tilaadiesel = new System.Windows.Forms.Button();
            this.tilausmaara98 = new System.Windows.Forms.TextBox();
            this.tilausmaaradiesel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polttoaine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Määrä:";
            // 
            // tilausmaara95
            // 
            this.tilausmaara95.Location = new System.Drawing.Point(217, 168);
            this.tilausmaara95.Name = "tilausmaara95";
            this.tilausmaara95.Size = new System.Drawing.Size(100, 22);
            this.tilausmaara95.TabIndex = 2;
            // 
            // tilaa95
            // 
            this.tilaa95.Location = new System.Drawing.Point(217, 85);
            this.tilaa95.Name = "tilaa95";
            this.tilaa95.Size = new System.Drawing.Size(75, 33);
            this.tilaa95.TabIndex = 6;
            this.tilaa95.Text = "95";
            this.tilaa95.UseVisualStyleBackColor = true;
            // 
            // tilaa98
            // 
            this.tilaa98.Location = new System.Drawing.Point(428, 85);
            this.tilaa98.Name = "tilaa98";
            this.tilaa98.Size = new System.Drawing.Size(75, 33);
            this.tilaa98.TabIndex = 7;
            this.tilaa98.Text = "98";
            this.tilaa98.UseVisualStyleBackColor = true;
            // 
            // tilaadiesel
            // 
            this.tilaadiesel.Location = new System.Drawing.Point(612, 85);
            this.tilaadiesel.Name = "tilaadiesel";
            this.tilaadiesel.Size = new System.Drawing.Size(75, 33);
            this.tilaadiesel.TabIndex = 8;
            this.tilaadiesel.Text = "Diesel";
            this.tilaadiesel.UseVisualStyleBackColor = true;
            // 
            // tilausmaara98
            // 
            this.tilausmaara98.Location = new System.Drawing.Point(428, 173);
            this.tilausmaara98.Name = "tilausmaara98";
            this.tilausmaara98.Size = new System.Drawing.Size(100, 22);
            this.tilausmaara98.TabIndex = 9;
            // 
            // tilausmaaradiesel
            // 
            this.tilausmaaradiesel.Location = new System.Drawing.Point(612, 173);
            this.tilausmaaradiesel.Name = "tilausmaaradiesel";
            this.tilausmaaradiesel.Size = new System.Drawing.Size(100, 22);
            this.tilausmaaradiesel.TabIndex = 10;
            // 
            // TilausLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 445);
            this.Controls.Add(this.tilausmaaradiesel);
            this.Controls.Add(this.tilausmaara98);
            this.Controls.Add(this.tilaadiesel);
            this.Controls.Add(this.tilaa98);
            this.Controls.Add(this.tilaa95);
            this.Controls.Add(this.tilausmaara95);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TilausLomake";
            this.Text = "Tilaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tilausmaara95;
        private System.Windows.Forms.Button tilaa95;
        private System.Windows.Forms.Button tilaa98;
        private System.Windows.Forms.Button tilaadiesel;
        private System.Windows.Forms.TextBox tilausmaara98;
        private System.Windows.Forms.TextBox tilausmaaradiesel;
    }
}