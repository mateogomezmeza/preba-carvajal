namespace preba_carvajal
{
    partial class inicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destino = new System.Windows.Forms.TextBox();
            this.origen = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.aerolinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numerovuelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.horasalida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.horallegada = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pRUEBADataSet = new preba_carvajal.PRUEBADataSet();
            this.vUELOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vUELOSTableAdapter = new preba_carvajal.PRUEBADataSetTableAdapters.VUELOSTableAdapter();
            this.nUMERODEVUELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEROLINEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRIGENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASALIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORALLEGADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODEVUELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUELOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMERODEVUELODataGridViewTextBoxColumn,
            this.aEROLINEADataGridViewTextBoxColumn,
            this.oRIGENDataGridViewTextBoxColumn,
            this.dESTINODataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn,
            this.hORASALIDADataGridViewTextBoxColumn,
            this.hORALLEGADADataGridViewTextBoxColumn,
            this.eSTADODEVUELODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vUELOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 117);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBox1);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.horallegada);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.horasalida);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.destino);
            this.panel.Controls.Add(this.origen);
            this.panel.Controls.Add(this.fecha);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.aerolinea);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.numerovuelo);
            this.panel.Location = new System.Drawing.Point(21, 36);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(642, 192);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado del vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen";
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(456, 75);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(157, 20);
            this.destino.TabIndex = 7;
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(456, 37);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(157, 20);
            this.origen.TabIndex = 6;
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dd/mm/aa";
            this.fecha.Location = new System.Drawing.Point(28, 114);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(197, 20);
            this.fecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha (dd/mm/yyyy)";
            // 
            // aerolinea
            // 
            this.aerolinea.Location = new System.Drawing.Point(28, 75);
            this.aerolinea.Name = "aerolinea";
            this.aerolinea.Size = new System.Drawing.Size(157, 20);
            this.aerolinea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aerolinea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de vuelo";
            // 
            // numerovuelo
            // 
            this.numerovuelo.Location = new System.Drawing.Point(28, 37);
            this.numerovuelo.Name = "numerovuelo";
            this.numerovuelo.Size = new System.Drawing.Size(157, 20);
            this.numerovuelo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "VUELOS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // horasalida
            // 
            this.horasalida.CustomFormat = "hh:mm:ss";
            this.horasalida.Location = new System.Drawing.Point(425, 114);
            this.horasalida.Name = "horasalida";
            this.horasalida.Size = new System.Drawing.Size(188, 20);
            this.horasalida.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hora salida (hh:mm:ss)";
            // 
            // horallegada
            // 
            this.horallegada.CustomFormat = "hh:mm:ss";
            this.horallegada.Location = new System.Drawing.Point(425, 153);
            this.horallegada.Name = "horallegada";
            this.horallegada.Size = new System.Drawing.Size(188, 20);
            this.horallegada.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hora llegada (hh:mm:ss)";
            // 
            // pRUEBADataSet
            // 
            this.pRUEBADataSet.DataSetName = "PRUEBADataSet";
            this.pRUEBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vUELOSBindingSource
            // 
            this.vUELOSBindingSource.DataMember = "VUELOS";
            this.vUELOSBindingSource.DataSource = this.pRUEBADataSet;
            // 
            // vUELOSTableAdapter
            // 
            this.vUELOSTableAdapter.ClearBeforeFill = true;
            // 
            // nUMERODEVUELODataGridViewTextBoxColumn
            // 
            this.nUMERODEVUELODataGridViewTextBoxColumn.DataPropertyName = "NUMERODEVUELO";
            this.nUMERODEVUELODataGridViewTextBoxColumn.HeaderText = "NUMERODEVUELO";
            this.nUMERODEVUELODataGridViewTextBoxColumn.Name = "nUMERODEVUELODataGridViewTextBoxColumn";
            // 
            // aEROLINEADataGridViewTextBoxColumn
            // 
            this.aEROLINEADataGridViewTextBoxColumn.DataPropertyName = "AEROLINEA";
            this.aEROLINEADataGridViewTextBoxColumn.HeaderText = "AEROLINEA";
            this.aEROLINEADataGridViewTextBoxColumn.Name = "aEROLINEADataGridViewTextBoxColumn";
            // 
            // oRIGENDataGridViewTextBoxColumn
            // 
            this.oRIGENDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN";
            this.oRIGENDataGridViewTextBoxColumn.HeaderText = "ORIGEN";
            this.oRIGENDataGridViewTextBoxColumn.Name = "oRIGENDataGridViewTextBoxColumn";
            // 
            // dESTINODataGridViewTextBoxColumn
            // 
            this.dESTINODataGridViewTextBoxColumn.DataPropertyName = "DESTINO";
            this.dESTINODataGridViewTextBoxColumn.HeaderText = "DESTINO";
            this.dESTINODataGridViewTextBoxColumn.Name = "dESTINODataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            // 
            // hORASALIDADataGridViewTextBoxColumn
            // 
            this.hORASALIDADataGridViewTextBoxColumn.DataPropertyName = "HORASALIDA";
            this.hORASALIDADataGridViewTextBoxColumn.HeaderText = "HORASALIDA";
            this.hORASALIDADataGridViewTextBoxColumn.Name = "hORASALIDADataGridViewTextBoxColumn";
            // 
            // hORALLEGADADataGridViewTextBoxColumn
            // 
            this.hORALLEGADADataGridViewTextBoxColumn.DataPropertyName = "HORALLEGADA";
            this.hORALLEGADADataGridViewTextBoxColumn.HeaderText = "HORALLEGADA";
            this.hORALLEGADADataGridViewTextBoxColumn.Name = "hORALLEGADADataGridViewTextBoxColumn";
            // 
            // eSTADODEVUELODataGridViewTextBoxColumn
            // 
            this.eSTADODEVUELODataGridViewTextBoxColumn.DataPropertyName = "ESTADODEVUELO";
            this.eSTADODEVUELODataGridViewTextBoxColumn.HeaderText = "ESTADODEVUELO";
            this.eSTADODEVUELODataGridViewTextBoxColumn.Name = "eSTADODEVUELODataGridViewTextBoxColumn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Proceso",
            "Finalizado"});
            this.comboBox1.Location = new System.Drawing.Point(28, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUELOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerovuelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker horallegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker horasalida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private PRUEBADataSet pRUEBADataSet;
        private System.Windows.Forms.BindingSource vUELOSBindingSource;
        private PRUEBADataSetTableAdapters.VUELOSTableAdapter vUELOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODEVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEROLINEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRIGENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORALLEGADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODEVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}