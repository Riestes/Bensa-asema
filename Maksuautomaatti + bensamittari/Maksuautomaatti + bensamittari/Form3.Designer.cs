namespace Maksuautomaatti___bensamittari
{
    partial class FormTankkaus
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
            this.button98 = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.buttonDiesel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tankkausBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button98
            // 
            this.button98.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button98.Location = new System.Drawing.Point(136, 134);
            this.button98.Name = "button98";
            this.button98.Size = new System.Drawing.Size(60, 58);
            this.button98.TabIndex = 0;
            this.button98.Text = "98";
            this.button98.UseVisualStyleBackColor = true;
            this.button98.Click += new System.EventHandler(this.button98_Click);
            // 
            // button95
            // 
            this.button95.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button95.Location = new System.Drawing.Point(43, 134);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(60, 58);
            this.button95.TabIndex = 1;
            this.button95.Text = "95";
            this.button95.UseVisualStyleBackColor = true;
            this.button95.Click += new System.EventHandler(this.button95_Click);
            // 
            // buttonDiesel
            // 
            this.buttonDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiesel.Location = new System.Drawing.Point(228, 134);
            this.buttonDiesel.Name = "buttonDiesel";
            this.buttonDiesel.Size = new System.Drawing.Size(88, 58);
            this.buttonDiesel.TabIndex = 2;
            this.buttonDiesel.Text = "Diesel";
            this.buttonDiesel.UseVisualStyleBackColor = true;
            this.buttonDiesel.Click += new System.EventHandler(this.buttonDiesel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paljonko tankataan?";
            // 
            // tankkausBox
            // 
            this.tankkausBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tankkausBox.Location = new System.Drawing.Point(114, 74);
            this.tankkausBox.Name = "tankkausBox";
            this.tankkausBox.Size = new System.Drawing.Size(52, 22);
            this.tankkausBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Euroa";
            // 
            // FormTankkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tankkausBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDiesel);
            this.Controls.Add(this.button95);
            this.Controls.Add(this.button98);
            this.Name = "FormTankkaus";
            this.Text = "Tankkaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button98;
        private System.Windows.Forms.Button button95;
        private System.Windows.Forms.Button buttonDiesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tankkausBox;
        private System.Windows.Forms.Label label2;
    }
}