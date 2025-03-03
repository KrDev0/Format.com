namespace Format.com
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLetraUnidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCapacidad = new System.Windows.Forms.ComboBox();
            this.comboSistemaArchivos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTamanoAsignacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsado = new System.Windows.Forms.Label();
            this.lblLibre = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSistemaArchivos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFormatoRapido = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnFormatear = new System.Windows.Forms.Button();
            this.checkBoxHabilitarCompresion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formatear unidad:";
            // 
            // lblLetraUnidad
            // 
            this.lblLetraUnidad.AutoSize = true;
            this.lblLetraUnidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLetraUnidad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLetraUnidad.Location = new System.Drawing.Point(180, 9);
            this.lblLetraUnidad.Name = "lblLetraUnidad";
            this.lblLetraUnidad.Size = new System.Drawing.Size(64, 25);
            this.lblLetraUnidad.TabIndex = 1;
            this.lblLetraUnidad.Text = "LETRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capacidad:";
            // 
            // comboCapacidad
            // 
            this.comboCapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCapacidad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboCapacidad.FormattingEnabled = true;
            this.comboCapacidad.Location = new System.Drawing.Point(12, 68);
            this.comboCapacidad.Name = "comboCapacidad";
            this.comboCapacidad.Size = new System.Drawing.Size(256, 29);
            this.comboCapacidad.TabIndex = 0;
            // 
            // comboSistemaArchivos
            // 
            this.comboSistemaArchivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSistemaArchivos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboSistemaArchivos.FormattingEnabled = true;
            this.comboSistemaArchivos.Location = new System.Drawing.Point(12, 133);
            this.comboSistemaArchivos.Name = "comboSistemaArchivos";
            this.comboSistemaArchivos.Size = new System.Drawing.Size(256, 29);
            this.comboSistemaArchivos.TabIndex = 1;
            this.comboSistemaArchivos.SelectedIndexChanged += new System.EventHandler(this.comboSistemaArchivos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema de archivos:";
            // 
            // comboBoxTamanoAsignacion
            // 
            this.comboBoxTamanoAsignacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTamanoAsignacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxTamanoAsignacion.FormattingEnabled = true;
            this.comboBoxTamanoAsignacion.Location = new System.Drawing.Point(12, 198);
            this.comboBoxTamanoAsignacion.Name = "comboBoxTamanoAsignacion";
            this.comboBoxTamanoAsignacion.Size = new System.Drawing.Size(256, 29);
            this.comboBoxTamanoAsignacion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamaño de unidad de asignación:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsado);
            this.groupBox1.Controls.Add(this.lblLibre);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblLetra);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblSistemaArchivos);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la unidad";
            // 
            // lblUsado
            // 
            this.lblUsado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsado.Location = new System.Drawing.Point(142, 122);
            this.lblUsado.Name = "lblUsado";
            this.lblUsado.Size = new System.Drawing.Size(105, 19);
            this.lblUsado.TabIndex = 11;
            this.lblUsado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibre
            // 
            this.lblLibre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLibre.Location = new System.Drawing.Point(142, 103);
            this.lblLibre.Name = "lblLibre";
            this.lblLibre.Size = new System.Drawing.Size(105, 19);
            this.lblLibre.TabIndex = 10;
            this.lblLibre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Espacio usado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(6, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Espacio libre:";
            // 
            // lblLetra
            // 
            this.lblLetra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLetra.Location = new System.Drawing.Point(142, 82);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(105, 19);
            this.lblLetra.TabIndex = 7;
            this.lblLetra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTipo.Location = new System.Drawing.Point(142, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(105, 19);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSistemaArchivos
            // 
            this.lblSistemaArchivos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSistemaArchivos.Location = new System.Drawing.Point(142, 42);
            this.lblSistemaArchivos.Name = "lblSistemaArchivos";
            this.lblSistemaArchivos.Size = new System.Drawing.Size(105, 19);
            this.lblSistemaArchivos.TabIndex = 5;
            this.lblSistemaArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNombre.Location = new System.Drawing.Point(142, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Letra de la unidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo de unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Formato de archivos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxHabilitarCompresion);
            this.groupBox2.Controls.Add(this.checkBoxFormatoRapido);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de formateo";
            // 
            // checkBoxFormatoRapido
            // 
            this.checkBoxFormatoRapido.AutoSize = true;
            this.checkBoxFormatoRapido.Checked = true;
            this.checkBoxFormatoRapido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFormatoRapido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFormatoRapido.Location = new System.Drawing.Point(6, 74);
            this.checkBoxFormatoRapido.Name = "checkBoxFormatoRapido";
            this.checkBoxFormatoRapido.Size = new System.Drawing.Size(129, 24);
            this.checkBoxFormatoRapido.TabIndex = 4;
            this.checkBoxFormatoRapido.Text = "Formato r&ápido";
            this.checkBoxFormatoRapido.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 25);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre de la unidad:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 537);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.Location = new System.Drawing.Point(12, 563);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 27);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFormatear
            // 
            this.btnFormatear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFormatear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFormatear.Location = new System.Drawing.Point(172, 563);
            this.btnFormatear.Name = "btnFormatear";
            this.btnFormatear.Size = new System.Drawing.Size(96, 27);
            this.btnFormatear.TabIndex = 6;
            this.btnFormatear.Text = "&Iniciar";
            this.btnFormatear.UseVisualStyleBackColor = true;
            this.btnFormatear.Click += new System.EventHandler(this.btnFormatear_Click);
            // 
            // checkBoxHabilitarCompresion
            // 
            this.checkBoxHabilitarCompresion.AutoSize = true;
            this.checkBoxHabilitarCompresion.Enabled = false;
            this.checkBoxHabilitarCompresion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxHabilitarCompresion.Location = new System.Drawing.Point(6, 104);
            this.checkBoxHabilitarCompresion.Name = "checkBoxHabilitarCompresion";
            this.checkBoxHabilitarCompresion.Size = new System.Drawing.Size(247, 24);
            this.checkBoxHabilitarCompresion.TabIndex = 5;
            this.checkBoxHabilitarCompresion.Text = "Compresión de archivos y carpetas";
            this.checkBoxHabilitarCompresion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 602);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFormatear);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTamanoAsignacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSistemaArchivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLetraUnidad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Formatear UNIDAD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLetraUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCapacidad;
        private System.Windows.Forms.ComboBox comboSistemaArchivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTamanoAsignacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSistemaArchivos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxFormatoRapido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFormatear;
        private System.Windows.Forms.Label lblUsado;
        private System.Windows.Forms.Label lblLibre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxHabilitarCompresion;
    }
}

