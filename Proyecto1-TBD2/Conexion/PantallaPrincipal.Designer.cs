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
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenustablas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Indices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearIndicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuIndices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarIndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarIndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Procedimientos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.añadirProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProcedimientos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Funciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuFunciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFuncionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Vistas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVistas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Triggers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuTriggers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Checks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuChecks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tablas.SuspendLayout();
            this.panel_conexiones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Basededatos.SuspendLayout();
            this.subMenustablas.SuspendLayout();
            this.Indices.SuspendLayout();
            this.subMenuIndices.SuspendLayout();
            this.Procedimientos.SuspendLayout();
            this.subMenuProcedimientos.SuspendLayout();
            this.Funciones.SuspendLayout();
            this.subMenuFunciones.SuspendLayout();
            this.Vistas.SuspendLayout();
            this.subMenuVistas.SuspendLayout();
            this.Triggers.SuspendLayout();
            this.subMenuTriggers.SuspendLayout();
            this.Checks.SuspendLayout();
            this.subMenuChecks.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(4, "iconfinder_stage-dynamic-process-phase-procedure_5969359.png");
            this.imageList1.Images.SetKeyName(5, "iconfinder_function_383136.png");
            this.imageList1.Images.SetKeyName(6, "iconfinder_icon-view_2867956.png");
            this.imageList1.Images.SetKeyName(7, "iconfinder_Electrical_plug_plug_plug_connector_plug_in_power_plug_4801292.png");
            this.imageList1.Images.SetKeyName(8, "iconfinder_ic_round_check_tick_5760403.png");
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
            this.propiedadesToolStripMenuItem,
            this.refrescarToolStripMenuItem});
            this.Basededatos.Name = "contextMenuStrip2";
            this.Basededatos.Size = new System.Drawing.Size(172, 70);
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
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            this.refrescarToolStripMenuItem.Click += new System.EventHandler(this.refrescarToolStripMenuItem_Click);
            // 
            // subMenustablas
            // 
            this.subMenustablas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDatosToolStripMenuItem,
            this.eliminarTablaToolStripMenuItem,
            this.modificarTablaToolStripMenuItem});
            this.subMenustablas.Name = "subMenustablas";
            this.subMenustablas.Size = new System.Drawing.Size(156, 70);
            // 
            // verDatosToolStripMenuItem
            // 
            this.verDatosToolStripMenuItem.Name = "verDatosToolStripMenuItem";
            this.verDatosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verDatosToolStripMenuItem.Text = "Ver Datos";
            this.verDatosToolStripMenuItem.Click += new System.EventHandler(this.verDatosToolStripMenuItem_Click);
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
            this.subMenuIndices.Size = new System.Drawing.Size(161, 48);
            // 
            // eliminarIndiceToolStripMenuItem
            // 
            this.eliminarIndiceToolStripMenuItem.Name = "eliminarIndiceToolStripMenuItem";
            this.eliminarIndiceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarIndiceToolStripMenuItem.Text = "Eliminar Indice";
            this.eliminarIndiceToolStripMenuItem.Click += new System.EventHandler(this.eliminarIndiceToolStripMenuItem_Click);
            // 
            // modificarIndiceToolStripMenuItem
            // 
            this.modificarIndiceToolStripMenuItem.Name = "modificarIndiceToolStripMenuItem";
            this.modificarIndiceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modificarIndiceToolStripMenuItem.Text = "Modificar Indice";
            // 
            // Procedimientos
            // 
            this.Procedimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirProcedimientoToolStripMenuItem});
            this.Procedimientos.Name = "Procedimientos";
            this.Procedimientos.Size = new System.Drawing.Size(191, 26);
            // 
            // añadirProcedimientoToolStripMenuItem
            // 
            this.añadirProcedimientoToolStripMenuItem.Name = "añadirProcedimientoToolStripMenuItem";
            this.añadirProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.añadirProcedimientoToolStripMenuItem.Text = "Añadir Procedimiento";
            this.añadirProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.añadirProcedimientoToolStripMenuItem_Click);
            // 
            // subMenuProcedimientos
            // 
            this.subMenuProcedimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProcedimientoToolStripMenuItem,
            this.modificarProcedimientoToolStripMenuItem,
            this.eliminarProcedimientoToolStripMenuItem});
            this.subMenuProcedimientos.Name = "subMenuProcedimientos";
            this.subMenuProcedimientos.Size = new System.Drawing.Size(207, 70);
            // 
            // verProcedimientoToolStripMenuItem
            // 
            this.verProcedimientoToolStripMenuItem.Name = "verProcedimientoToolStripMenuItem";
            this.verProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.verProcedimientoToolStripMenuItem.Text = "Ver Procedimiento";
            this.verProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.verProcedimientoToolStripMenuItem_Click);
            // 
            // modificarProcedimientoToolStripMenuItem
            // 
            this.modificarProcedimientoToolStripMenuItem.Name = "modificarProcedimientoToolStripMenuItem";
            this.modificarProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.modificarProcedimientoToolStripMenuItem.Text = "Modificar Procedimiento";
            this.modificarProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.modificarProcedimientoToolStripMenuItem_Click);
            // 
            // eliminarProcedimientoToolStripMenuItem
            // 
            this.eliminarProcedimientoToolStripMenuItem.Name = "eliminarProcedimientoToolStripMenuItem";
            this.eliminarProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.eliminarProcedimientoToolStripMenuItem.Text = "Eliminar Procedimiento";
            this.eliminarProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProcedimientoToolStripMenuItem_Click);
            // 
            // Funciones
            // 
            this.Funciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProcedimientoToolStripMenuItem});
            this.Funciones.Name = "Funciones";
            this.Funciones.Size = new System.Drawing.Size(163, 26);
            // 
            // agregarProcedimientoToolStripMenuItem
            // 
            this.agregarProcedimientoToolStripMenuItem.Name = "agregarProcedimientoToolStripMenuItem";
            this.agregarProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.agregarProcedimientoToolStripMenuItem.Text = "Agregar Funcion";
            this.agregarProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.agregarProcedimientoToolStripMenuItem_Click);
            // 
            // subMenuFunciones
            // 
            this.subMenuFunciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFuncionToolStripMenuItem,
            this.eliminarFuncionToolStripMenuItem,
            this.modificarFuncionToolStripMenuItem});
            this.subMenuFunciones.Name = "subMenuFunciones";
            this.subMenuFunciones.Size = new System.Drawing.Size(172, 70);
            // 
            // abrirFuncionToolStripMenuItem
            // 
            this.abrirFuncionToolStripMenuItem.Name = "abrirFuncionToolStripMenuItem";
            this.abrirFuncionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.abrirFuncionToolStripMenuItem.Text = "Abrir Funcion";
            this.abrirFuncionToolStripMenuItem.Click += new System.EventHandler(this.abrirFuncionToolStripMenuItem_Click);
            // 
            // eliminarFuncionToolStripMenuItem
            // 
            this.eliminarFuncionToolStripMenuItem.Name = "eliminarFuncionToolStripMenuItem";
            this.eliminarFuncionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarFuncionToolStripMenuItem.Text = "Eliminar Funcion";
            this.eliminarFuncionToolStripMenuItem.Click += new System.EventHandler(this.eliminarFuncionToolStripMenuItem_Click);
            // 
            // modificarFuncionToolStripMenuItem
            // 
            this.modificarFuncionToolStripMenuItem.Name = "modificarFuncionToolStripMenuItem";
            this.modificarFuncionToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modificarFuncionToolStripMenuItem.Text = "Modificar Funcion";
            this.modificarFuncionToolStripMenuItem.Click += new System.EventHandler(this.modificarFuncionToolStripMenuItem_Click);
            // 
            // Vistas
            // 
            this.Vistas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVistaToolStripMenuItem});
            this.Vistas.Name = "Vistas";
            this.Vistas.Size = new System.Drawing.Size(145, 26);
            // 
            // agregarVistaToolStripMenuItem
            // 
            this.agregarVistaToolStripMenuItem.Name = "agregarVistaToolStripMenuItem";
            this.agregarVistaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.agregarVistaToolStripMenuItem.Text = "Agregar Vista";
            this.agregarVistaToolStripMenuItem.Click += new System.EventHandler(this.agregarVistaToolStripMenuItem_Click);
            // 
            // subMenuVistas
            // 
            this.subMenuVistas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verVistaToolStripMenuItem,
            this.modificarVistaToolStripMenuItem,
            this.eliminarVistaToolStripMenuItem});
            this.subMenuVistas.Name = "subMenuVistas";
            this.subMenuVistas.Size = new System.Drawing.Size(154, 70);
            // 
            // verVistaToolStripMenuItem
            // 
            this.verVistaToolStripMenuItem.Name = "verVistaToolStripMenuItem";
            this.verVistaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.verVistaToolStripMenuItem.Text = "Ver Vista";
            this.verVistaToolStripMenuItem.Click += new System.EventHandler(this.verVistaToolStripMenuItem_Click);
            // 
            // modificarVistaToolStripMenuItem
            // 
            this.modificarVistaToolStripMenuItem.Name = "modificarVistaToolStripMenuItem";
            this.modificarVistaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modificarVistaToolStripMenuItem.Text = "Modificar Vista";
            this.modificarVistaToolStripMenuItem.Click += new System.EventHandler(this.modificarVistaToolStripMenuItem_Click);
            // 
            // eliminarVistaToolStripMenuItem
            // 
            this.eliminarVistaToolStripMenuItem.Name = "eliminarVistaToolStripMenuItem";
            this.eliminarVistaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eliminarVistaToolStripMenuItem.Text = "Eliminar Vista";
            this.eliminarVistaToolStripMenuItem.Click += new System.EventHandler(this.eliminarVistaToolStripMenuItem_Click);
            // 
            // Triggers
            // 
            this.Triggers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTriggerToolStripMenuItem});
            this.Triggers.Name = "Triggers";
            this.Triggers.Size = new System.Drawing.Size(156, 26);
            // 
            // agregarTriggerToolStripMenuItem
            // 
            this.agregarTriggerToolStripMenuItem.Name = "agregarTriggerToolStripMenuItem";
            this.agregarTriggerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.agregarTriggerToolStripMenuItem.Text = "Agregar Trigger";
            this.agregarTriggerToolStripMenuItem.Click += new System.EventHandler(this.agregarTriggerToolStripMenuItem_Click);
            // 
            // subMenuTriggers
            // 
            this.subMenuTriggers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTriggerToolStripMenuItem,
            this.modificarTriggerToolStripMenuItem,
            this.eliminarTriggerToolStripMenuItem});
            this.subMenuTriggers.Name = "subMenuTriggers";
            this.subMenuTriggers.Size = new System.Drawing.Size(165, 70);
            // 
            // verTriggerToolStripMenuItem
            // 
            this.verTriggerToolStripMenuItem.Name = "verTriggerToolStripMenuItem";
            this.verTriggerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.verTriggerToolStripMenuItem.Text = "Ver Trigger";
            this.verTriggerToolStripMenuItem.Click += new System.EventHandler(this.verTriggerToolStripMenuItem_Click);
            // 
            // modificarTriggerToolStripMenuItem
            // 
            this.modificarTriggerToolStripMenuItem.Name = "modificarTriggerToolStripMenuItem";
            this.modificarTriggerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modificarTriggerToolStripMenuItem.Text = "Modificar Trigger";
            this.modificarTriggerToolStripMenuItem.Click += new System.EventHandler(this.modificarTriggerToolStripMenuItem_Click);
            // 
            // eliminarTriggerToolStripMenuItem
            // 
            this.eliminarTriggerToolStripMenuItem.Name = "eliminarTriggerToolStripMenuItem";
            this.eliminarTriggerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarTriggerToolStripMenuItem.Text = "Eliminar Trigger";
            this.eliminarTriggerToolStripMenuItem.Click += new System.EventHandler(this.eliminarTriggerToolStripMenuItem_Click);
            // 
            // Checks
            // 
            this.Checks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCheckToolStripMenuItem});
            this.Checks.Name = "Checks";
            this.Checks.Size = new System.Drawing.Size(153, 26);
            // 
            // agregarCheckToolStripMenuItem
            // 
            this.agregarCheckToolStripMenuItem.Name = "agregarCheckToolStripMenuItem";
            this.agregarCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCheckToolStripMenuItem.Text = "Agregar Check";
            this.agregarCheckToolStripMenuItem.Click += new System.EventHandler(this.agregarCheckToolStripMenuItem_Click);
            // 
            // subMenuChecks
            // 
            this.subMenuChecks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCheckToolStripMenuItem,
            this.modificarCheckToolStripMenuItem,
            this.eliminarCheckToolStripMenuItem});
            this.subMenuChecks.Name = "subMenuChecks";
            this.subMenuChecks.Size = new System.Drawing.Size(181, 92);
            // 
            // abrirCheckToolStripMenuItem
            // 
            this.abrirCheckToolStripMenuItem.Name = "abrirCheckToolStripMenuItem";
            this.abrirCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirCheckToolStripMenuItem.Text = "Abrir Check";
            this.abrirCheckToolStripMenuItem.Click += new System.EventHandler(this.abrirCheckToolStripMenuItem_Click);
            // 
            // modificarCheckToolStripMenuItem
            // 
            this.modificarCheckToolStripMenuItem.Name = "modificarCheckToolStripMenuItem";
            this.modificarCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarCheckToolStripMenuItem.Text = "Modificar Check";
            this.modificarCheckToolStripMenuItem.Click += new System.EventHandler(this.modificarCheckToolStripMenuItem_Click);
            // 
            // eliminarCheckToolStripMenuItem
            // 
            this.eliminarCheckToolStripMenuItem.Name = "eliminarCheckToolStripMenuItem";
            this.eliminarCheckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCheckToolStripMenuItem.Text = "Eliminar Check";
            this.eliminarCheckToolStripMenuItem.Click += new System.EventHandler(this.eliminarCheckToolStripMenuItem_Click);
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
            this.Procedimientos.ResumeLayout(false);
            this.subMenuProcedimientos.ResumeLayout(false);
            this.Funciones.ResumeLayout(false);
            this.subMenuFunciones.ResumeLayout(false);
            this.Vistas.ResumeLayout(false);
            this.subMenuVistas.ResumeLayout(false);
            this.Triggers.ResumeLayout(false);
            this.subMenuTriggers.ResumeLayout(false);
            this.Checks.ResumeLayout(false);
            this.subMenuChecks.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem eliminarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDatosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Indices;
        private System.Windows.Forms.ToolStripMenuItem crearIndicesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuIndices;
        private System.Windows.Forms.ToolStripMenuItem eliminarIndiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarIndiceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Procedimientos;
        private System.Windows.Forms.ToolStripMenuItem añadirProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuProcedimientos;
        private System.Windows.Forms.ToolStripMenuItem verProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Funciones;
        private System.Windows.Forms.ToolStripMenuItem agregarProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuFunciones;
        private System.Windows.Forms.ToolStripMenuItem abrirFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFuncionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFuncionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Vistas;
        private System.Windows.Forms.ToolStripMenuItem agregarVistaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuVistas;
        private System.Windows.Forms.ToolStripMenuItem verVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVistaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Triggers;
        private System.Windows.Forms.ContextMenuStrip subMenuTriggers;
        private System.Windows.Forms.ToolStripMenuItem agregarTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTriggerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Checks;
        private System.Windows.Forms.ToolStripMenuItem agregarCheckToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip subMenuChecks;
        private System.Windows.Forms.ToolStripMenuItem abrirCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCheckToolStripMenuItem;
    }
}

