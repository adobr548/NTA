namespace L3_NTA
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
            this.Duomenys = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ivestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spausdinimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzduotiesVeiksmaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rajonaiBePasikartojimuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrinktasSarasasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rikiavimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzduotisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagalbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Rezultatai = new System.Windows.Forms.RichTextBox();
            this.TipoIvedimas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Duomenys
            // 
            this.Duomenys.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Duomenys.Location = new System.Drawing.Point(12, 27);
            this.Duomenys.Name = "Duomenys";
            this.Duomenys.Size = new System.Drawing.Size(392, 230);
            this.Duomenys.TabIndex = 0;
            this.Duomenys.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.uzduotiesVeiksmaiToolStripMenuItem,
            this.uzduotisToolStripMenuItem,
            this.pagalbaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ivestiToolStripMenuItem,
            this.spausdinimasToolStripMenuItem,
            this.baigtiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // ivestiToolStripMenuItem
            // 
            this.ivestiToolStripMenuItem.Name = "ivestiToolStripMenuItem";
            this.ivestiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ivestiToolStripMenuItem.Text = "Ivesti";
            this.ivestiToolStripMenuItem.Click += new System.EventHandler(this.ivestiToolStripMenuItem_Click);
            // 
            // spausdinimasToolStripMenuItem
            // 
            this.spausdinimasToolStripMenuItem.Name = "spausdinimasToolStripMenuItem";
            this.spausdinimasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.spausdinimasToolStripMenuItem.Text = "Spausdinimas";
            this.spausdinimasToolStripMenuItem.Click += new System.EventHandler(this.spausdinimasToolStripMenuItem_Click);
            // 
            // baigtiToolStripMenuItem
            // 
            this.baigtiToolStripMenuItem.Name = "baigtiToolStripMenuItem";
            this.baigtiToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.baigtiToolStripMenuItem.Text = "Baigti";
            this.baigtiToolStripMenuItem.Click += new System.EventHandler(this.baigtiToolStripMenuItem_Click_1);
            // 
            // uzduotiesVeiksmaiToolStripMenuItem
            // 
            this.uzduotiesVeiksmaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duMaxToolStripMenuItem,
            this.rajonaiBePasikartojimuToolStripMenuItem,
            this.atrinktasSarasasToolStripMenuItem,
            this.rikiavimasToolStripMenuItem});
            this.uzduotiesVeiksmaiToolStripMenuItem.Name = "uzduotiesVeiksmaiToolStripMenuItem";
            this.uzduotiesVeiksmaiToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.uzduotiesVeiksmaiToolStripMenuItem.Text = "Uzduoties veiksmai";
            // 
            // duMaxToolStripMenuItem
            // 
            this.duMaxToolStripMenuItem.Name = "duMaxToolStripMenuItem";
            this.duMaxToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.duMaxToolStripMenuItem.Text = "Du Max Namai";
            this.duMaxToolStripMenuItem.Click += new System.EventHandler(this.duMaxToolStripMenuItem_Click);
            // 
            // rajonaiBePasikartojimuToolStripMenuItem
            // 
            this.rajonaiBePasikartojimuToolStripMenuItem.Name = "rajonaiBePasikartojimuToolStripMenuItem";
            this.rajonaiBePasikartojimuToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rajonaiBePasikartojimuToolStripMenuItem.Text = "Rajonai be pasikartojimu";
            this.rajonaiBePasikartojimuToolStripMenuItem.Click += new System.EventHandler(this.rajonaiBePasikartojimuToolStripMenuItem_Click);
            // 
            // naujasSarasasToolStripMenuItem
            // 
            this.atrinktasSarasasToolStripMenuItem.Name = "naujasSarasasToolStripMenuItem";
            this.atrinktasSarasasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.atrinktasSarasasToolStripMenuItem.Text = "Atrinktas sarasas";
            this.atrinktasSarasasToolStripMenuItem.Click += new System.EventHandler(this.atrinktasSarasasToolStripMenuItem_Click);
            // 
            // rikiavimasToolStripMenuItem
            // 
            this.rikiavimasToolStripMenuItem.Name = "rikiavimasToolStripMenuItem";
            this.rikiavimasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rikiavimasToolStripMenuItem.Text = "Rikiavimas";
            this.rikiavimasToolStripMenuItem.Click += new System.EventHandler(this.rikiavimasToolStripMenuItem_Click);
            // 
            // uzduotisToolStripMenuItem
            // 
            this.uzduotisToolStripMenuItem.Name = "uzduotisToolStripMenuItem";
            this.uzduotisToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.uzduotisToolStripMenuItem.Text = "Uzduotis";
            this.uzduotisToolStripMenuItem.Click += new System.EventHandler(this.uzduotisToolStripMenuItem_Click);
            // 
            // pagalbaToolStripMenuItem
            // 
            this.pagalbaToolStripMenuItem.Name = "pagalbaToolStripMenuItem";
            this.pagalbaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pagalbaToolStripMenuItem.Text = "Pagalba";
            this.pagalbaToolStripMenuItem.Click += new System.EventHandler(this.pagalbaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Rezultatai
            // 
            this.Rezultatai.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Rezultatai.Location = new System.Drawing.Point(13, 281);
            this.Rezultatai.Name = "Rezultatai";
            this.Rezultatai.Size = new System.Drawing.Size(715, 342);
            this.Rezultatai.TabIndex = 2;
            this.Rezultatai.Text = "";
            // 
            // TipoIvedimas
            // 
            this.TipoIvedimas.Location = new System.Drawing.Point(563, 59);
            this.TipoIvedimas.Name = "TipoIvedimas";
            this.TipoIvedimas.Size = new System.Drawing.Size(134, 20);
            this.TipoIvedimas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(427, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iveskite namo tipa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoIvedimas);
            this.Controls.Add(this.Rezultatai);
            this.Controls.Add(this.Duomenys);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "L3 NTA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Duomenys;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ivestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzduotiesVeiksmaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzduotisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagalbaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox Rezultatai;
        private System.Windows.Forms.ToolStripMenuItem spausdinimasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rajonaiBePasikartojimuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrinktasSarasasToolStripMenuItem;
        private System.Windows.Forms.TextBox TipoIvedimas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem rikiavimasToolStripMenuItem;
    }
}

