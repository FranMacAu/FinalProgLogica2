namespace FinalPL2
{
    partial class frmReportePorRol
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
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(104, 41);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(268, 24);
            this.cmbRoles.TabIndex = 1;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdGenerarReporte);
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Rol para reporte";
            // 
            // cmdGenerarReporte
            // 
            this.cmdGenerarReporte.Enabled = false;
            this.cmdGenerarReporte.Location = new System.Drawing.Point(243, 99);
            this.cmdGenerarReporte.Name = "cmdGenerarReporte";
            this.cmdGenerarReporte.Size = new System.Drawing.Size(129, 38);
            this.cmdGenerarReporte.TabIndex = 3;
            this.cmdGenerarReporte.Text = "Generar Reporte";
            this.cmdGenerarReporte.UseVisualStyleBackColor = true;
            this.cmdGenerarReporte.Click += new System.EventHandler(this.cmdGenerarReporte_Click);
            // 
            // frmReportePorRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportePorRol";
            this.Text = "Reporte por Rol";
            this.Load += new System.EventHandler(this.frmReportePorRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGenerarReporte;
    }
}