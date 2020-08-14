namespace Proyecto1_TBD2.Tablas {
    partial class MostrarDatosTabla {
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
            this.control_tabla = new System.Windows.Forms.TabControl();
            this.Datos = new System.Windows.Forms.TabPage();
            this.data_tablas = new System.Windows.Forms.DataGridView();
            this.tabla_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.control_tabla.SuspendLayout();
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // control_tabla
            // 
            this.control_tabla.Controls.Add(this.Datos);
            this.control_tabla.Font = new System.Drawing.Font("Verdana", 12F);
            this.control_tabla.Location = new System.Drawing.Point(65, 79);
            this.control_tabla.Name = "control_tabla";
            this.control_tabla.SelectedIndex = 0;
            this.control_tabla.Size = new System.Drawing.Size(650, 428);
            this.control_tabla.TabIndex = 0;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.data_tablas);
            this.Datos.Location = new System.Drawing.Point(4, 27);
            this.Datos.Name = "Datos";
            this.Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Datos.Size = new System.Drawing.Size(642, 397);
            this.Datos.TabIndex = 0;
            this.Datos.Text = "Datos";
            this.Datos.UseVisualStyleBackColor = true;
            // 
            // data_tablas
            // 
            this.data_tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_tablas.Location = new System.Drawing.Point(3, 3);
            this.data_tablas.Name = "data_tablas";
            this.data_tablas.Size = new System.Drawing.Size(636, 391);
            this.data_tablas.TabIndex = 0;
            this.data_tablas.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.data_tablas_CellBeginEdit);
            this.data_tablas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tablas_CellEndEdit);
            // 
            // tabla_name
            // 
            this.tabla_name.AutoSize = true;
            this.tabla_name.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabla_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabla_name.Location = new System.Drawing.Point(274, 32);
            this.tabla_name.Name = "tabla_name";
            this.tabla_name.Size = new System.Drawing.Size(58, 18);
            this.tabla_name.TabIndex = 1;
            this.tabla_name.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F);
            this.button1.Location = new System.Drawing.Point(163, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F);
            this.button2.Location = new System.Drawing.Point(65, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 12F);
            this.button3.Location = new System.Drawing.Point(613, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MostrarDatosTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 557);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabla_name);
            this.Controls.Add(this.control_tabla);
            this.Name = "MostrarDatosTabla";
            this.Text = "MostrarDatosTabla";
            this.Load += new System.EventHandler(this.MostrarDatosTabla_Load);
            this.control_tabla.ResumeLayout(false);
            this.Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl control_tabla;
        private System.Windows.Forms.TabPage Datos;
        private System.Windows.Forms.DataGridView data_tablas;
        private System.Windows.Forms.Label tabla_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}