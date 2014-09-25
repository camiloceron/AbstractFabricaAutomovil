namespace AbstractFactoryAutomovil
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_crear = new System.Windows.Forms.Button();
            this.lst_partes = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_mazda = new System.Windows.Forms.RadioButton();
            this.rad_renault = new System.Windows.Forms.RadioButton();
            this.radKia = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_crear);
            this.panel1.Controls.Add(this.lst_partes);
            this.panel1.Controls.Add(this.lbl_tipo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 255);
            this.panel1.TabIndex = 0;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(88, 140);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(96, 23);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // lst_partes
            // 
            this.lst_partes.FormattingEnabled = true;
            this.lst_partes.Items.AddRange(new object[] {
            "Auto",
            "Motor",
            "Carroceria\t"});
            this.lst_partes.Location = new System.Drawing.Point(81, 93);
            this.lst_partes.Name = "lst_partes";
            this.lst_partes.Size = new System.Drawing.Size(121, 21);
            this.lst_partes.TabIndex = 2;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(30, 96);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.radKia);
            this.groupBox1.Controls.Add(this.rad_mazda);
            this.groupBox1.Controls.Add(this.rad_renault);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // rad_mazda
            // 
            this.rad_mazda.AutoSize = true;
            this.rad_mazda.Location = new System.Drawing.Point(100, 26);
            this.rad_mazda.Name = "rad_mazda";
            this.rad_mazda.Size = new System.Drawing.Size(57, 17);
            this.rad_mazda.TabIndex = 1;
            this.rad_mazda.TabStop = true;
            this.rad_mazda.Text = "Mazda";
            this.rad_mazda.UseVisualStyleBackColor = true;
            this.rad_mazda.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_renault
            // 
            this.rad_renault.AutoSize = true;
            this.rad_renault.Checked = true;
            this.rad_renault.Location = new System.Drawing.Point(20, 26);
            this.rad_renault.Name = "rad_renault";
            this.rad_renault.Size = new System.Drawing.Size(62, 17);
            this.rad_renault.TabIndex = 0;
            this.rad_renault.TabStop = true;
            this.rad_renault.Text = "Renault";
            this.rad_renault.UseVisualStyleBackColor = true;
            // 
            // radKia
            // 
            this.radKia.AutoSize = true;
            this.radKia.Location = new System.Drawing.Point(182, 26);
            this.radKia.Name = "radKia";
            this.radKia.Size = new System.Drawing.Size(40, 17);
            this.radKia.TabIndex = 2;
            this.radKia.TabStop = true;
            this.radKia.Text = "Kia";
            this.radKia.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_mazda;
        private System.Windows.Forms.RadioButton rad_renault;
        private System.Windows.Forms.ComboBox lst_partes;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.RadioButton radKia;

    }
}

