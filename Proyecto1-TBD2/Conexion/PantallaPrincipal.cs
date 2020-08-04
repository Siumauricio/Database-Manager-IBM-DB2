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
using Proyecto1_TBD2.Indices;
using Proyecto1_TBD2.Procedimientos;
using Proyecto1_TBD2.Tablas;

namespace Proyecto1_TBD2 { 
    public partial class PantallaPrincipal:Form {
        List<ContextMenuStrip> menus = new List<ContextMenuStrip>();

        public PantallaPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void n_conexion_Click(object sender, EventArgs e) {
            menus.Add(Tablas);
            menus.Add(Basededatos);
            menus.Add(subMenustablas);
            menus.Add(Indices);
            menus.Add(subMenuIndices);
            menus.Add(Procedimientos);
            menus.Add(subMenuProcedimientos) ;
            IngresarConexion ic = new IngresarConexion(arbol_conexiones, menus);
            ic.Show();
        }
        public void AddConexion(String db) {
            arbol_conexiones.Nodes.Add(db);
        }

        private void añadirTablaToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearTablas ct = new CrearTablas(arbol_conexiones,menus);
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
            ModificarTabla mt = new ModificarTabla(arbol_conexiones);
            mt.Show();
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

        private void crearIndicesToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearIndice cd = new CrearIndice(arbol_conexiones,menus);
            cd.Show();
        }

        private void eliminarIndiceToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNode node = arbol_conexiones.SelectedNode;
            DB2Connection connect = obtenerConexion(node.Parent.Parent.Text);
            string query = @"DROP INDEX " + node.Text + ";";
            try {
                connect.Open();
                DB2Command cmd = new DB2Command(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Su indice ha sido eliminado correctamente!");
                arbol_conexiones.SelectedNode.Remove();

            } catch (DB2Exception ex) {
                MessageBox.Show("Ha ocurrido un error al eliminar su indice!\n" + ex.Message);
            }
            connect.Close();
        }

        private void añadirProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            CrearProcedimientos cp = new CrearProcedimientos();
            cp.Show();
        }

        private void verProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            MostrarProcedimiento md = new MostrarProcedimiento(arbol_conexiones);
            md.Show();

        }

        private void modificarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarProcedimiento md = new ModificarProcedimiento(arbol_conexiones);
            md.Show();
        }

        private void eliminarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e) {
            DB2Connection connection = obtenerConexion(arbol_conexiones.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command("DROP PROCEDURE "+arbol_conexiones.SelectedNode.Text+";", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Procedimiento Borrado!");
                arbol_conexiones.SelectedNode.Remove();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar procedimiento almacenado!\n"+ex.Message);
            }
            connection.Close();

        }
    }
}
