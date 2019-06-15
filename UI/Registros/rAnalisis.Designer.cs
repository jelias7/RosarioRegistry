namespace Rosario_Registry.UI.Registros
{
    partial class rAnalisis
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
            this.components = new System.ComponentModel.Container();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ResultadodataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.TipoAnalisisbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(66, 22);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(106, 20);
            this.IDnumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(66, 62);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.FechadateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(66, 100);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(241, 21);
            this.UsuariocomboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(15, 173);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(202, 21);
            this.TipocomboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Analisis:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(276, 174);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(143, 20);
            this.ResultadotextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(428, 174);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(48, 23);
            this.Agregarbutton.TabIndex = 10;
            this.Agregarbutton.Text = "+";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ResultadodataGridView
            // 
            this.ResultadodataGridView.AllowUserToAddRows = false;
            this.ResultadodataGridView.AllowUserToDeleteRows = false;
            this.ResultadodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadodataGridView.Location = new System.Drawing.Point(15, 212);
            this.ResultadodataGridView.Name = "ResultadodataGridView";
            this.ResultadodataGridView.ReadOnly = true;
            this.ResultadodataGridView.Size = new System.Drawing.Size(458, 150);
            this.ResultadodataGridView.TabIndex = 11;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Rosario_Registry.Properties.Resources.Search_find_locate_1542;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(179, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 29);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Rosario_Registry.Properties.Resources.check_ok_accept_apply_1582;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(222, 406);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Rosario_Registry.Properties.Resources.delete_delete_exit_1577;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(303, 406);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 56);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Rosario_Registry.Properties.Resources.add_insert_plus_1588;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(141, 406);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 56);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Rosario_Registry.Properties.Resources.delete_delete_exit_1577;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(15, 368);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(110, 32);
            this.Removerbutton.TabIndex = 12;
            this.Removerbutton.Text = "Remover Fila";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // TipoAnalisisbutton
            // 
            this.TipoAnalisisbutton.Location = new System.Drawing.Point(222, 173);
            this.TipoAnalisisbutton.Name = "TipoAnalisisbutton";
            this.TipoAnalisisbutton.Size = new System.Drawing.Size(48, 21);
            this.TipoAnalisisbutton.TabIndex = 17;
            this.TipoAnalisisbutton.Text = "+";
            this.TipoAnalisisbutton.UseVisualStyleBackColor = true;
            this.TipoAnalisisbutton.Click += new System.EventHandler(this.TipoAnalisisbutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 474);
            this.Controls.Add(this.TipoAnalisisbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.ResultadodataGridView);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDnumericUpDown);
            this.Name = "rAnalisis";
            this.Text = "Registro de Analisis Medico";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView ResultadodataGridView;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button TipoAnalisisbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}