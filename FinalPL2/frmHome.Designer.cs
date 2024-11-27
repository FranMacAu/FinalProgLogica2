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
            this.reportePorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePróximosCumpleañosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarDatosDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.rRHHToolStripMenuItem.Text = "RRHH";
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
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unoToolStripMenuItem,
            this.reporteDeTodosLosProductosToolStripMenuItem});
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.producciónToolStripMenuItem.Text = "Producción";
            // 
            // unoToolStripMenuItem
            // 
            this.unoToolStripMenuItem.Name = "unoToolStripMenuItem";
            this.unoToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.unoToolStripMenuItem.Text = "Reporte de Búsqueda de Productos";
            this.unoToolStripMenuItem.Click += new System.EventHandler(this.unoToolStripMenuItem_Click);
            // 
            // reporteDeTodosLosProductosToolStripMenuItem
            // 
            this.reporteDeTodosLosProductosToolStripMenuItem.Name = "reporteDeTodosLosProductosToolStripMenuItem";
            this.reporteDeTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(326, 26);
            this.reporteDeTodosLosProductosToolStripMenuItem.Text = "Reporte de todos los productos";
            this.reporteDeTodosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeTodosLosProductosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(228, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(410, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = ".SRL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(222, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Herramienta de reportes";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem unoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeTodosLosProductosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

