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
            menus.Add(subMenustablas);
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

        private void editarTablaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

   

        private void eliminarTablaToolStripMenuItem_Click_1(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            DB2Connection connect = obtenerConexion(node.Parent.Parent.Text);
            string query = @"DROP TABLE " + node.Text + " ;";
            try {
                connect.Open();
                DB2Command cmd = new DB2Command(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su tabla ha sido eliminada correctamente!");
            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error al eliminar su tabla!\n" + ex.Message);
            }
            connect.Close();
            arbol_conexiones.SelectedNode.Remove();
        }

        private void modificarTablaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void verTablaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void eliminarConexionToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            node.Remove();
        }

        private void verDatosToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarDatosTabla md = new MostrarDatosTabla(arbol_conexiones);
            md.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        public DB2Connection obtenerConexion(string usuario) {
            DB2ConnectionStringBuilder cn = new DB2ConnectionStringBuilder();
            cn.UserID = "db2admin";
            cn.Password = "siumauricio";
            cn.Database = usuario;
            cn.Server = "localhost";
            DB2Connection connect = new DB2Connection(cn.ToString());
            return connect;
        }
    }
}
