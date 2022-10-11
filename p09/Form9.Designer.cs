namespace p09
{
    partial class Form9
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "aaaeeeiiiooouuuyyysss";
            // 
            // buttonO
            // 
            this.buttonO.Enabled = false;
            this.buttonO.Location = new System.Drawing.Point(3, 99);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(75, 23);
            this.buttonO.TabIndex = 3;
            this.buttonO.Text = "o";
            this.buttonO.UseVisualStyleBackColor = true;
            // 
            // buttonU
            // 
            this.buttonU.Enabled = false;
            this.buttonU.Location = new System.Drawing.Point(3, 128);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(75, 23);
            this.buttonU.TabIndex = 4;
            this.buttonU.Text = "u";
            this.buttonU.UseVisualStyleBackColor = true;
            // 
            // buttonI
            // 
            this.buttonI.Enabled = false;
            this.buttonI.Location = new System.Drawing.Point(3, 70);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(75, 23);
            this.buttonI.TabIndex = 2;
            this.buttonI.Text = "i";
            this.buttonI.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Enabled = false;
            this.buttonE.Location = new System.Drawing.Point(3, 41);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 23);
            this.buttonE.TabIndex = 1;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            this.buttonA.Enabled = false;
            this.buttonA.Location = new System.Drawing.Point(3, 12);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 23);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "a";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(104, 32);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "ulož";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonY
            // 
            this.buttonY.Enabled = false;
            this.buttonY.Location = new System.Drawing.Point(3, 157);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(75, 23);
            this.buttonY.TabIndex = 5;
            this.buttonY.Text = "y";
            this.buttonY.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonY);
            this.panel1.Controls.Add(this.buttonU);
            this.panel1.Controls.Add(this.buttonI);
            this.panel1.Controls.Add(this.buttonA);
            this.panel1.Controls.Add(this.buttonO);
            this.panel1.Controls.Add(this.buttonE);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 196);
            this.panel1.TabIndex = 8;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Name = "Form9";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Panel panel1;
    }
}

