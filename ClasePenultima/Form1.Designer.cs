namespace ClasePenultima
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
            this.buttonNueva = new System.Windows.Forms.Button();
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.labelNivelDePoder = new System.Windows.Forms.Label();
            this.numericUpDownNivelDePoder = new System.Windows.Forms.NumericUpDown();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRazas = new System.Windows.Forms.ComboBox();
            this.labelDescripcionPJ = new System.Windows.Forms.Label();
            this.textBoxDPJ = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dateTimePickerEnetrada = new System.Windows.Forms.DateTimePicker();
            this.labelFentrada = new System.Windows.Forms.Label();
            this.labelFsalida = new System.Windows.Forms.Label();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscarF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelDePoder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNueva
            // 
            this.buttonNueva.Location = new System.Drawing.Point(439, 210);
            this.buttonNueva.Name = "buttonNueva";
            this.buttonNueva.Size = new System.Drawing.Size(115, 35);
            this.buttonNueva.TabIndex = 0;
            this.buttonNueva.Text = "Prueba";
            this.buttonNueva.UseVisualStyleBackColor = true;
            this.buttonNueva.Click += new System.EventHandler(this.buttonNueva_Click);
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(439, 267);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(776, 363);
            this.dataGridViewPersonajes.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(1100, 210);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(115, 35);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(38, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(38, 65);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(38, 100);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(39, 16);
            this.labelRaza.TabIndex = 5;
            this.labelRaza.Text = "Raza";
            // 
            // labelNivelDePoder
            // 
            this.labelNivelDePoder.AutoSize = true;
            this.labelNivelDePoder.Location = new System.Drawing.Point(38, 179);
            this.labelNivelDePoder.Name = "labelNivelDePoder";
            this.labelNivelDePoder.Size = new System.Drawing.Size(96, 16);
            this.labelNivelDePoder.TabIndex = 6;
            this.labelNivelDePoder.Text = "Nivel de poder";
            // 
            // numericUpDownNivelDePoder
            // 
            this.numericUpDownNivelDePoder.Location = new System.Drawing.Point(152, 179);
            this.numericUpDownNivelDePoder.Name = "numericUpDownNivelDePoder";
            this.numericUpDownNivelDePoder.Size = new System.Drawing.Size(195, 22);
            this.numericUpDownNivelDePoder.TabIndex = 7;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(152, 100);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(195, 22);
            this.textBoxRaza.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(152, 59);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(195, 22);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(152, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(195, 22);
            this.textBoxID.TabIndex = 10;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(41, 232);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(134, 30);
            this.buttonInsertar.TabIndex = 11;
            this.buttonInsertar.Text = "Crear";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Razas";
            // 
            // comboBoxRazas
            // 
            this.comboBoxRazas.FormattingEnabled = true;
            this.comboBoxRazas.Location = new System.Drawing.Point(152, 142);
            this.comboBoxRazas.Name = "comboBoxRazas";
            this.comboBoxRazas.Size = new System.Drawing.Size(195, 24);
            this.comboBoxRazas.TabIndex = 13;
            this.comboBoxRazas.SelectedIndexChanged += new System.EventHandler(this.comboBoxRazas_SelectedIndexChanged);
            // 
            // labelDescripcionPJ
            // 
            this.labelDescripcionPJ.AutoSize = true;
            this.labelDescripcionPJ.Location = new System.Drawing.Point(489, 100);
            this.labelDescripcionPJ.Name = "labelDescripcionPJ";
            this.labelDescripcionPJ.Size = new System.Drawing.Size(203, 16);
            this.labelDescripcionPJ.TabIndex = 14;
            this.labelDescripcionPJ.Text = "Descripcion breve del personaje";
            // 
            // textBoxDPJ
            // 
            this.textBoxDPJ.Location = new System.Drawing.Point(715, 100);
            this.textBoxDPJ.Name = "textBoxDPJ";
            this.textBoxDPJ.Size = new System.Drawing.Size(500, 22);
            this.textBoxDPJ.TabIndex = 15;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(213, 233);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(134, 29);
            this.buttonEliminar.TabIndex = 16;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(124, 281);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(134, 30);
            this.buttonBuscar.TabIndex = 17;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dateTimePickerEnetrada
            // 
            this.dateTimePickerEnetrada.Location = new System.Drawing.Point(41, 384);
            this.dateTimePickerEnetrada.Name = "dateTimePickerEnetrada";
            this.dateTimePickerEnetrada.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerEnetrada.TabIndex = 18;
            // 
            // labelFentrada
            // 
            this.labelFentrada.AutoSize = true;
            this.labelFentrada.Location = new System.Drawing.Point(38, 352);
            this.labelFentrada.Name = "labelFentrada";
            this.labelFentrada.Size = new System.Drawing.Size(113, 16);
            this.labelFentrada.TabIndex = 19;
            this.labelFentrada.Text = "Fecha de entrada";
            // 
            // labelFsalida
            // 
            this.labelFsalida.AutoSize = true;
            this.labelFsalida.Location = new System.Drawing.Point(38, 435);
            this.labelFsalida.Name = "labelFsalida";
            this.labelFsalida.Size = new System.Drawing.Size(104, 16);
            this.labelFsalida.TabIndex = 20;
            this.labelFsalida.Text = "Fecha de salida";
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Location = new System.Drawing.Point(41, 473);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(266, 22);
            this.dateTimePickerSalida.TabIndex = 21;
            // 
            // buttonBuscarF
            // 
            this.buttonBuscarF.Location = new System.Drawing.Point(124, 529);
            this.buttonBuscarF.Name = "buttonBuscarF";
            this.buttonBuscarF.Size = new System.Drawing.Size(134, 30);
            this.buttonBuscarF.TabIndex = 22;
            this.buttonBuscarF.Text = "Buscar Fecha";
            this.buttonBuscarF.UseVisualStyleBackColor = true;
            this.buttonBuscarF.Click += new System.EventHandler(this.buttonBuscarF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 667);
            this.Controls.Add(this.buttonBuscarF);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.labelFsalida);
            this.Controls.Add(this.labelFentrada);
            this.Controls.Add(this.dateTimePickerEnetrada);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxDPJ);
            this.Controls.Add(this.labelDescripcionPJ);
            this.Controls.Add(this.comboBoxRazas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.numericUpDownNivelDePoder);
            this.Controls.Add(this.labelNivelDePoder);
            this.Controls.Add(this.labelRaza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Controls.Add(this.buttonNueva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelDePoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNueva;
        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.Label labelNivelDePoder;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelDePoder;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRazas;
        private System.Windows.Forms.Label labelDescripcionPJ;
        private System.Windows.Forms.TextBox textBoxDPJ;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnetrada;
        private System.Windows.Forms.Label labelFentrada;
        private System.Windows.Forms.Label labelFsalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.Button buttonBuscarF;
    }
}

