namespace Rosario_Registry
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rCargosToolStripMenuItem,
            this.rUsuariosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // rCargosToolStripMenuItem
            // 
            this.rCargosToolStripMenuItem.Name = "rCargosToolStripMenuItem";
            this.rCargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rCargosToolStripMenuItem.Text = "Cargos";
            this.rCargosToolStripMenuItem.Click += new System.EventHandler(this.rCargosToolStripMenuItem_Click);
            // 
            // rUsuariosToolStripMenuItem
            // 
            this.rUsuariosToolStripMenuItem.Name = "rUsuariosToolStripMenuItem";
            this.rUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rUsuariosToolStripMenuItem.Text = "Usuarios";
            this.rUsuariosToolStripMenuItem.Click += new System.EventHandler(this.rUsuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUsuariosToolStripMenuItem1,
            this.cCargosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cUsuariosToolStripMenuItem1
            // 
            this.cUsuariosToolStripMenuItem1.Name = "cUsuariosToolStripMenuItem1";
            this.cUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cUsuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // cCargosToolStripMenuItem
            // 
            this.cCargosToolStripMenuItem.Name = "cCargosToolStripMenuItem";
            this.cCargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cCargosToolStripMenuItem.Text = "Cargos";
            this.cCargosToolStripMenuItem.Click += new System.EventHandler(this.cCargosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cCargosToolStripMenuItem;
    }
}

