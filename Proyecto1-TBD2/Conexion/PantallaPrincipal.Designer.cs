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
            this.Tablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_conexiones = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.n_conexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tablas.SuspendLayout();
            this.panel_conexiones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // Tablas
            // 
            this.Tablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirTablaToolStripMenuItem,
            this.editarTablaToolStripMenuItem,
            this.eliminarTablaToolStripMenuItem});
            this.Tablas.Name = "menu1";
            this.Tablas.Size = new System.Drawing.Size(148, 70);
            // 
            // añadirTablaToolStripMenuItem
            // 
            this.añadirTablaToolStripMenuItem.Name = "añadirTablaToolStripMenuItem";
            this.añadirTablaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.añadirTablaToolStripMenuItem.Text = "Añadir Tabla";
            this.añadirTablaToolStripMenuItem.Click += new System.EventHandler(this.añadirTablaToolStripMenuItem_Click);
            // 
            // editarTablaToolStripMenuItem
            // 
            this.editarTablaToolStripMenuItem.Name = "editarTablaToolStripMenuItem";
            this.editarTablaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarTablaToolStripMenuItem.Text = "Editar Tabla";
            // 
            // eliminarTablaToolStripMenuItem
            // 
            this.eliminarTablaToolStripMenuItem.Name = "eliminarTablaToolStripMenuItem";
            this.eliminarTablaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.eliminarTablaToolStripMenuItem.Text = "Eliminar Tabla";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_database_299089.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_icon-folder_211608.png");
            this.imageList1.Images.SetKeyName(2, "iconfinder_098_Spreadsheet_183529.png");
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
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 695);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 695);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "IBM DB2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tablas.ResumeLayout(false);
            this.panel_conexiones.ResumeLayout(false);
            this.panel_conexiones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView arbol_conexiones;
        private System.Windows.Forms.Panel panel_conexiones;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button n_conexion;
        private System.Windows.Forms.ContextMenuStrip Tablas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem añadirTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
    }
}

