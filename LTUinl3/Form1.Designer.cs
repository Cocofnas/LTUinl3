namespace LTUinl3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFörnamn = new TextBox();
            txtEfternamn = new TextBox();
            txtPersonnummer = new TextBox();
            btnOk = new Button();
            txtResultat = new TextBox();
            btnAvsluta = new Button();
            menuStrip1 = new MenuStrip();
            registreraPersonToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 119);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Förnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 174);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Efternamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 227);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Personnummer";
            label3.Click += label3_Click;
            // 
            // txtFörnamn
            // 
            txtFörnamn.Location = new Point(210, 119);
            txtFörnamn.Name = "txtFörnamn";
            txtFörnamn.Size = new Size(125, 27);
            txtFörnamn.TabIndex = 3;
            // 
            // txtEfternamn
            // 
            txtEfternamn.Location = new Point(210, 171);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(125, 27);
            txtEfternamn.TabIndex = 4;
            // 
            // txtPersonnummer
            // 
            txtPersonnummer.Location = new Point(210, 224);
            txtPersonnummer.Name = "txtPersonnummer";
            txtPersonnummer.Size = new Size(125, 27);
            txtPersonnummer.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(186, 268);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtResultat
            // 
            txtResultat.Location = new Point(91, 354);
            txtResultat.Multiline = true;
            txtResultat.Name = "txtResultat";
            txtResultat.Size = new Size(236, 109);
            txtResultat.TabIndex = 7;
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(186, 481);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(94, 29);
            btnAvsluta.TabIndex = 8;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registreraPersonToolStripMenuItem, avslutaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(880, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // registreraPersonToolStripMenuItem
            // 
            registreraPersonToolStripMenuItem.Name = "registreraPersonToolStripMenuItem";
            registreraPersonToolStripMenuItem.Size = new Size(139, 24);
            registreraPersonToolStripMenuItem.Text = "Registrera person";
            registreraPersonToolStripMenuItem.Click += registreraPersonToolStripMenuItem_Click;
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(71, 24);
            avslutaToolStripMenuItem.Text = "Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(91, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 10;
            textBox1.Text = "VÄLKOMMEN!";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.MenuHighlight;
            textBox2.Location = new Point(91, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 20);
            textBox2.TabIndex = 11;
            textBox2.Text = "Ange namn och personnummer nedan";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(100, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 12;
            textBox3.Text = "Resultat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 538);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAvsluta);
            Controls.Add(txtResultat);
            Controls.Add(btnOk);
            Controls.Add(txtPersonnummer);
            Controls.Add(txtEfternamn);
            Controls.Add(txtFörnamn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFörnamn;
        private TextBox txtEfternamn;
        private TextBox txtPersonnummer;
        private Button btnOk;
        private TextBox txtResultat;
        private Button btnAvsluta;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registreraPersonToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
