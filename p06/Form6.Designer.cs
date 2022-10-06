namespace p06
{
    partial class Form6
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
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSoucet = new System.Windows.Forms.Button();
            this.labelSoucet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(79, 43);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(100, 20);
            this.textBoxA1.TabIndex = 0;
            this.textBoxA1.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a2:";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(79, 69);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(100, 20);
            this.textBoxA2.TabIndex = 2;
            this.textBoxA2.Text = "5";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(195, 43);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "zadat";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "n:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(79, 95);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 5;
            this.textBoxN.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "p:";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(79, 121);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 20);
            this.textBoxP.TabIndex = 7;
            this.textBoxP.Text = "3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 9;
            // 
            // buttonSoucet
            // 
            this.buttonSoucet.Location = new System.Drawing.Point(79, 174);
            this.buttonSoucet.Name = "buttonSoucet";
            this.buttonSoucet.Size = new System.Drawing.Size(75, 23);
            this.buttonSoucet.TabIndex = 10;
            this.buttonSoucet.Text = "součet";
            this.buttonSoucet.UseVisualStyleBackColor = true;
            this.buttonSoucet.Click += new System.EventHandler(this.buttonSoucet_Click);
            // 
            // labelSoucet
            // 
            this.labelSoucet.AutoSize = true;
            this.labelSoucet.Location = new System.Drawing.Point(76, 200);
            this.labelSoucet.Name = "labelSoucet";
            this.labelSoucet.Size = new System.Drawing.Size(42, 13);
            this.labelSoucet.TabIndex = 11;
            this.labelSoucet.Text = "součet:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 360);
            this.Controls.Add(this.labelSoucet);
            this.Controls.Add(this.buttonSoucet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA1);
            this.Name = "Form6";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSoucet;
        private System.Windows.Forms.Label labelSoucet;
    }
}

