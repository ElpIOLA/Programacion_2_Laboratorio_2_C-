namespace EjercicioClase06
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ssssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssssssToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ssssssToolStripMenuItem
            // 
            this.ssssssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinataToolStripMenuItem,
            this.plumaToolStripMenuItem});
            this.ssssssToolStripMenuItem.Name = "ssssssToolStripMenuItem";
            this.ssssssToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ssssssToolStripMenuItem.Text = "Administrar";
            this.ssssssToolStripMenuItem.Click += new System.EventHandler(this.ssssssToolStripMenuItem_Click);
            // 
            // tinataToolStripMenuItem
            // 
            this.tinataToolStripMenuItem.Name = "tinataToolStripMenuItem";
            this.tinataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tinataToolStripMenuItem.Text = "Tinta";
            this.tinataToolStripMenuItem.Click += new System.EventHandler(this.tinataToolStripMenuItem_Click);
            // 
            // plumaToolStripMenuItem
            // 
            this.plumaToolStripMenuItem.Name = "plumaToolStripMenuItem";
            this.plumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plumaToolStripMenuItem.Text = "Pluma";
            this.plumaToolStripMenuItem.Click += new System.EventHandler(this.plumaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(389, 315);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem ssssssToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tinataToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plumaToolStripMenuItem;
  }
}

