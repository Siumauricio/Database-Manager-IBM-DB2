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
    public partial class ModificarVista:Form {
        TreeView arbol;
        string valor = "";
        public ModificarVista(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void ModificarVista_Load(object sender, EventArgs e) {
            
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"select NAME, TEXT from SYSIBM.SYSVIEWS WHERE CREATOR='DB2ADMIN' and NAME='" + arbol.SelectedNode.Text + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TEXT"].ToString().ToUpper();
                    valor = buffer ["NAME"].ToString();
                    int pl = function.IndexOf("SELECT");
                    function = function.Substring(pl);
                    richTextBox1.Text = function;
                    textBox1.Text = valor;
                    break;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al mostrar Vista\n" + ex.Message);
            }
        }
        public void comprobarSintaxis() {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (textBox1.Text == valor) {
                richTextBox2.Text = "CREATE OR REPLACE VIEW " + valor + "\nAS\n" + richTextBox1.Text + ";";
            } else {
                richTextBox2.Text = "DROP VIEW "+valor+";\n CREATE VIEW " + textBox1.Text + "\nAS\n" + richTextBox1.Text + ";";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox2.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vista modificada correctamente");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("error al modificar vista\n" + ex.Message);
            }
        }
    }
}
