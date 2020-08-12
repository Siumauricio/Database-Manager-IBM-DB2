namespace Proyecto1_TBD2.Indices {
    partial class CrearIndice {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabla = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.data_set = new System.Windows.Forms.DataGridView();
            this.Expresion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ddl = new System.Windows.Forms.RichTextBox();
            this.nombre_indice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.caja2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabla.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_set)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.Controls.Add(this.tabPage1);
            this.tabla.Controls.Add(this.tabPage2);
            this.tabla.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabla.Location = new System.Drawing.Point(88, 166);
            this.tabla.Name = "tabla";
            this.tabla.SelectedIndex = 0;
            this.tabla.Size = new System.Drawing.Size(583, 314);
            this.tabla.TabIndex = 0;
            this.tabla.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_set);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Indices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // data_set
            // 
            this.data_set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_set.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expresion,
            this.Orden});
            this.data_set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_set.Location = new System.Drawing.Point(3, 3);
            this.data_set.Name = "data_set";
            this.data_set.Size = new System.Drawing.Size(569, 277);
            this.data_set.TabIndex = 0;
            // 
            // Expresion
            // 
            this.Expresion.HeaderText = "Expresion";
            this.Expresion.Name = "Expresion";
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.Items.AddRange(new object[] {
            "NINGUNO",
            "ASC",
            "DESC"});
            this.Orden.Name = "Orden";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddl);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ddl
            // 
            this.ddl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddl.Location = new System.Drawing.Point(3, 3);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(569, 277);
            this.ddl.TabIndex = 0;
            this.ddl.Text = "";
            // 
            // nombre_indice
            // 
            this.nombre_indice.Font = new System.Drawing.Font("Verdana", 12F);
            this.nombre_indice.Location = new System.Drawing.Point(300, 57);
            this.nombre_indice.Name = "nombre_indice";
            this.nombre_indice.Size = new System.Drawing.Size(255, 27);
            this.nombre_indice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(167, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Indice";
            // 
            // caja
            // 
            this.caja.Font = new System.Drawing.Font("Verdana", 12F);
            this.caja.FormattingEnabled = true;
            this.caja.Location = new System.Drawing.Point(300, 97);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(255, 26);
            this.caja.TabIndex = 3;
            this.caja.SelectedIndexChanged += new System.EventHandler(this.caja_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(167, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Tabla";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(164, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de indice";
            // 
            // caja2
            // 
            this.caja2.Font = new System.Drawing.Font("Verdana", 12F);
            this.caja2.FormattingEnabled = true;
            this.caja2.Items.AddRange(new object[] {
            "NO UNICO",
            "UNICO"});
            this.caja2.Location = new System.Drawing.Point(300, 133);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(255, 26);
            this.caja2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_indice);
            this.Controls.Add(this.tabla);
            this.Name = "CrearIndice";
            this.Text = "CrearIndice";
            this.Load += new System.EventHandler(this.CrearIndice_Load);
            this.tabla.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_set)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabla;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nombre_indice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_set;
        private System.Windows.Forms.DataGridViewComboBoxColumn Expresion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Orden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox caja2;
        private System.Windows.Forms.RichTextBox ddl;
        private System.Windows.Forms.Button button2;
    }
}