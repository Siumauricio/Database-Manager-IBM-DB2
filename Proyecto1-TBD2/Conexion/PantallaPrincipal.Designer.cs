namespace Proyecto1_TBD2 {
    partial class PantallaPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.arbol_conexiones = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Tablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_conexiones = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.n_conexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Basededatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenustablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Indices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearIndicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuIndices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarIndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarIndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tablas.SuspendLayout();
            this.panel_conexiones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Basededatos.SuspendLayout();
            this.subMenustablas.SuspendLayout();
            this.Indices.SuspendLayout();
            this.subMenuIndices.SuspendLayout();
            this.SuspendLayout();
            // 
            // arbol_conexiones
            // 
            this.arbol_conexiones.ForeColor = System.Drawing.Color.Black;
            this.arbol_conexiones.ImageIndex = 0;
            this.arbol_conexiones.ImageList = this.imageList1;
            this.arbol_conexiones.Location = new System.Drawing.Point(3, 93);
            this.arbol_conexiones.Name = "arbol_conexiones";
            this.arbol_conexiones.SelectedImageIndex = 0;
            this.arbol_conexiones.Size = new System.Drawing.Size(218, 495);
            this.arbol_conexiones.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_database_299089.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_icon-folder_211608.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_098_Spreadsheet_183529.png");
            this.imageList1.Images.SetKeyName(3, "iconfinder_key-password-main-keys-privilege_3643767.png");
            // 
            // Tablas
            // 
            this.Tablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirTablaToolStripMenuItem});
            this.Tablas.Name = "menu1";
            this.Tablas.Size = new System.Drawing.Size(140, 26);
            // 
            // añadirTablaToolStripMenuItem
            // 
            this.añadirTablaToolStripMenuItem.Name = "añadirTablaToolStripMenuItem";
            this.añadirTablaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.añadirTablaToolStripMenuItem.Text = "Añadir Tabla";
            this.añadirTablaToolStripMenuItem.Click += new System.EventHandler(this.añadirTablaToolStripMenuItem_Click);
            // 
            // panel_conexiones
            // 
            this.panel_conexiones.Controls.Add(this.refresh);
            this.panel_conexiones.Controls.Add(this.n_conexion);
            this.panel_conexiones.Controls.Add(this.label1);
            this.panel_conexiones.Location = new System.Drawing.Point(6, 27);
            this.panel_conexiones.Name = "panel_conexiones";
            this.panel_conexiones.Size = new System.Drawing.Size(215, 60);
            this.panel_conexiones.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.refresh.Location = new System.Drawing.Point(130, 33);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // n_conexion
            // 
            this.n_conexion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_conexion.Location = new System.Drawing.Point(0, 33);
            this.n_conexion.Name = "n_conexion";
            this.n_conexion.Size = new System.Drawing.Size(124, 24);
            this.n_conexion.TabIndex = 1;
            this.n_conexion.Text = "Nueva Conexion";
            this.n_conexion.UseVisualStyleBackColor = true;
            this.n_conexion.Click += new System.EventHandler(this.n_conexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexiones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.arbol_conexiones);
            this.panel1.Controls.Add(this.panel_conexiones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 695);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Basededatos
            // 
            this.Basededatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarConexionToolStripMenuItem,
            this.propiedadesToolStripMenuItem});
            this.Basededatos.Name = "contextMenuStrip2";
            this.Basededatos.Size = new System.Drawing.Size(172, 48);
            // 
            // eliminarConexionToolStripMenuItem
            // 
            this.eliminarConexionToolStripMenuItem.Name = "eliminarConexionToolStripMenuItem";
            this.eliminarConexionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarConexionToolStripMenuItem.Text = "Eliminar Conexion";
            this.eliminarConexionToolStripMenuItem.Click += new System.EventHandler(this.eliminarConexionToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // subMenustablas
            // 
            this.subMenustablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDatosToolStripMenuItem,
            this.verTablaToolStripMenuItem,
            this.eliminarTablaToolStripMenuItem,
            this.modificarTablaToolStripMenuItem});
            this.subMenustablas.Name = "subMenustablas";
            this.subMenustablas.Size = new System.Drawing.Size(156, 92);
            // 
            // verDatosToolStripMenuItem
            // 
            this.verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            this.verDatosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verDatosToolStripMenuItem.Text = "Ver Datos";
            this.verDatosToolStripMenuItem.Click += new System.EventHandler(this.verDatosToolStripMenuItem_Click);
            // 
            // verTablaToolStripMenuItem
            // 
            this.verTablaToolStripMenuItem.Name = "verTablaToolStripMenuItem";
            this.verTablaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verTablaToolStripMenuItem.Text = "Ver Tabla";
            this.verTablaToolStripMenuItem.Click += new System.EventHandler(this.verTablaToolStripMenuItem_Click);
            // 
            // eliminarTablaToolStripMenuItem
            // 
            this.eliminarTablaToolStripMenuItem.Name = "eliminarTablaToolStripMenuItem";
            this.eliminarTablaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eliminarTablaToolStripMenuItem.Text = "Eliminar Tabla";
            this.eliminarTablaToolStripMenuItem.Click += new System.EventHandler(this.eliminarTablaToolStripMenuItem_Click_1);
            // 
            // modificarTablaToolStripMenuItem
            // 
            this.modificarTablaToolStripMenuItem.Name = "modificarTablaToolStripMenuItem";
            this.modificarTablaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modificarTablaToolStripMenuItem.Text = "Modificar Tabla";
            this.modificarTablaToolStripMenuItem.Click += new System.EventHandler(this.modificarTablaToolStripMenuItem_Click);
            // 
            // Indices
            // 
            this.Indices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearIndicesToolStripMenuItem});
            this.Indices.Name = "Indices";
            this.Indices.Size = new System.Drawing.Size(143, 26);
            // 
            // crearIndicesToolStripMenuItem
            // 
            this.crearIndicesToolStripMenuItem.Name = "crearIndicesToolStripMenuItem";
            this.crearIndicesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.crearIndicesToolStripMenuItem.Text = "Crear Indices";
            this.crearIndicesToolStripMenuItem.Click += new System.EventHandler(this.crearIndicesToolStripMenuItem_Click);
            // 
            // subMenuIndices
            // 
            this.subMenuIndices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarIndiceToolStripMenuItem,
            this.modificarIndiceToolStripMenuItem});
            this.subMenuIndices.Name = "subMenuIndices";
            this.subMenuIndices.Size = new System.Drawing.Size(181, 70);
            // 
            // eliminarIndiceToolStripMenuItem
            // 
            this.eliminarIndiceToolStripMenuItem.Name = "eliminarIndiceToolStripMenuItem";
            this.eliminarIndiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarIndiceToolStripMenuItem.Text = "Eliminar Indice";
            this.eliminarIndiceToolStripMenuItem.Click += new System.EventHandler(this.eliminarIndiceToolStripMenuItem_Click);
            // 
            // modificarIndiceToolStripMenuItem
            // 
            this.modificarIndiceToolStripMenuItem.Name = "modificarIndiceToolStripMenuItem";
            this.modificarIndiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarIndiceToolStripMenuItem.Text = "Modificar Indice";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 695);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipal";
            this.Text = "IBM DB2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tablas.ResumeLayout(false);
            this.panel_conexiones.ResumeLayout(false);
            this.panel_conexiones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Basededatos.ResumeLayout(false);
            this.subMenustablas.ResumeLayout(false);
            this.Indices.ResumeLayout(false);
            this.subMenuIndices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView arbol_conexiones;
        private System.Windows.Forms.Panel panel_conexiones;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button n_conexion;
        private System.Windows.Forms.ContextMenuStrip Tablas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem añadirTablaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Basededatos;
        private System.Windows.Forms.ToolStripMenuItem eliminarConexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenustablas;
        private System.Windows.Forms.ToolStripMenuItem verTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDatosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Indices;
        private System.Windows.Forms.ToolStripMenuItem crearIndicesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuIndices;
        private System.Windows.Forms.ToolStripMenuItem eliminarIndiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarIndiceToolStripMenuItem;
    }
}

