namespace FinalPL2
{
    partial class frmModificarEmpleado
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationalIDNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.txtVacationHours = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(526, 69);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(98, 25);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NationalIDNumber:";
            // 
            // txtNationalIDNumber
            // 
            this.txtNationalIDNumber.Location = new System.Drawing.Point(254, 72);
            this.txtNationalIDNumber.Name = "txtNationalIDNumber";
            this.txtNationalIDNumber.Size = new System.Drawing.Size(237, 22);
            this.txtNationalIDNumber.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdModificar);
            this.groupBox1.Controls.Add(this.txtVacationHours);
            this.groupBox1.Controls.Add(this.txtMaritalStatus);
            this.groupBox1.Controls.Add(this.txtJobTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(97, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(432, 93);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(106, 69);
            this.cmdModificar.TabIndex = 6;
            this.cmdModificar.Text = "Guardar cambios";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // txtVacationHours
            // 
            this.txtVacationHours.BackColor = System.Drawing.Color.Linen;
            this.txtVacationHours.Location = new System.Drawing.Point(204, 169);
            this.txtVacationHours.Name = "txtVacationHours";
            this.txtVacationHours.ReadOnly = true;
            this.txtVacationHours.Size = new System.Drawing.Size(141, 22);
            this.txtVacationHours.TabIndex = 5;
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.BackColor = System.Drawing.Color.Linen;
            this.txtMaritalStatus.Location = new System.Drawing.Point(204, 107);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.ReadOnly = true;
            this.txtMaritalStatus.Size = new System.Drawing.Size(141, 22);
            this.txtMaritalStatus.TabIndex = 4;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.BackColor = System.Drawing.Color.Linen;
            this.txtJobTitle.Location = new System.Drawing.Point(204, 56);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.ReadOnly = true;
            this.txtJobTitle.Size = new System.Drawing.Size(141, 22);
            this.txtJobTitle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vacation Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marital Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job Title:";
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNationalIDNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBuscar);
            this.Name = "frmModificarEmpleado";
            this.Text = "Modificar datos de un empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNationalIDNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.TextBox txtVacationHours;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtJobTitle;
    }
}