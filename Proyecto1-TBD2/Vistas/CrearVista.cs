using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2.Vistas {
    public partial class CrearVista:Form {
        TreeView arbol;
        public CrearVista(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void CrearVista_Load(object sender, EventArgs e) {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox2.Text = "CREATE VIEW " + textBox1.Text + "\nAS\n" + richTextBox1.Text + ";";
       }

        public void comprobarSintaxis() {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("No se ha encontrado ningun error en SQL");
            } catch (DB2Exception ex) {
                MessageBox.Show("Revise la sintaxis\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            comprobarSintaxis();
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox2.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vista Creada correctamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error  al crear vista\n" + ex.Message);
            }
        }
    }
}
