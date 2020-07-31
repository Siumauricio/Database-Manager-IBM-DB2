using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2;
using IBM.Data.DB2.iSeries;
using Proyecto1_TBD2.Conexion;
using Proyecto1_TBD2.Tablas;

namespace Proyecto1_TBD2 { 
    public partial class PantallaPrincipal:Form {
        public PantallaPrincipal() {
            InitializeComponent();
            //TreeNode arbol = arbol_conexiones.Nodes.Add("IBM DB2 ");
           // arbol_conexiones.
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void arbol_conexiones_AfterSelect(object sender, TreeViewEventArgs e) {
            //MessageBox.Show("Version servidor: " + connect.ServerVersion + "Base de datos: " + connect.Database.ToString());
           // DB2Connection connect = new DB2Connection("Database=SAMPLE;UserID=db2admin;Password=siumauricio;Server=xxx.xxx.xxx.xxx:50000");
        }

        private void n_conexion_Click(object sender, EventArgs e) {
            List<ContextMenuStrip> menus = new List<ContextMenuStrip>();
            menus.Add(Tablas);
            menus.Add(Basededatos);
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            ic.Show();
        }
        public void AddConexion(String db) {
            arbol_conexiones.Nodes.Add(db);
        }

        private void añadirTablaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearTablas ct = new CrearTablas(arbol_conexiones);
            ct.Show();
        }

        private void administrarConexionToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
