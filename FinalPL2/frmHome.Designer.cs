namespace FinalPL2
{
    partial class frmHome
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
            this.rRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePróximosCumpleañosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarDatosDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rRHHToolStripMenuItem,
            this.producciónToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rRHHToolStripMenuItem
            // 
            this.rRHHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePorToolStripMenuItem,
            this.reportePróximosCumpleañosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modificarDatosDeEmpleadoToolStripMenuItem});
            this.rRHHToolStripMenuItem.Name = "rRHHToolStripMenuItem";
            this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.rRHHToolStripMenuItem.Text = "RRHH";
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.producciónToolStripMenuItem.Text = "Producción";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reportePorToolStripMenuItem
            // 
            this.reportePorToolStripMenuItem.Name = "reportePorToolStripMenuItem";
            this.reportePorToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.reportePorToolStripMenuItem.Text = "Reporte por  Rol";
            this.reportePorToolStripMenuItem.Click += new System.EventHandler(this.reportePorToolStripMenuItem_Click);
            // 
            // reportePróximosCumpleañosToolStripMenuItem
            // 
            this.reportePróximosCumpleañosToolStripMenuItem.Name = "reportePróximosCumpleañosToolStripMenuItem";
            this.reportePróximosCumpleañosToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.reportePróximosCumpleañosToolStripMenuItem.Text = "Reporte próximos Cumpleaños";
            this.reportePróximosCumpleañosToolStripMenuItem.Click += new System.EventHandler(this.reportePróximosCumpleañosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(294, 6);
            // 
            // modificarDatosDeEmpleadoToolStripMenuItem
            // 
            this.modificarDatosDeEmpleadoToolStripMenuItem.Name = "modificarDatosDeEmpleadoToolStripMenuItem";
            this.modificarDatosDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.modificarDatosDeEmpleadoToolStripMenuItem.Text = "Modificar datos de empleado";
            this.modificarDatosDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeEmpleadoToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Reporting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rRHHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePróximosCumpleañosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeEmpleadoToolStripMenuItem;
    }
}

