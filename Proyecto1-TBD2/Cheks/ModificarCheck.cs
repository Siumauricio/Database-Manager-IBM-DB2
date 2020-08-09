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

namespace Proyecto1_TBD2.Cheks {
    public partial class ModificarCheck:Form {
        TreeView arbol;
        string nombre_real = "";
        string checkviejo = "";
        public ModificarCheck(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void ModificarCheck_Load(object sender, EventArgs e) {
            textBox1.Text = arbol.SelectedNode.Text;
            nombre_real = arbol.SelectedNode.Text;
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT TEXT FROM SYSIBM.SYSCHECKS WHERE TBCREATOR='DB2ADMIN' AND NAME ='" + arbol.SelectedNode.Text + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TEXT"].ToString();
                    richTextBox1.Text = function;
                    checkviejo = function;
                    break;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al mostrar Check\n" + ex.Message);
            }
        }
        public string obtenerTabla() {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(@"SELECT TBNAME FROM SYSIBM.SYSCHECKS WHERE TBCREATOR='DB2ADMIN' AND NAME ='" + arbol.SelectedNode.Text + "';", connection);
                DB2DataReader buffer = cmd.ExecuteReader();
                while (buffer.Read()) {
                    var function = buffer ["TBNAME"].ToString();
                    return function;
                }
            } catch (DB2Exception ex) {
                MessageBox.Show("Error \n" + ex.Message);
            }
            return "";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox2.Text = "";
            string tabla = obtenerTabla();
            if (nombre_real !=textBox1.Text && checkviejo == richTextBox1.Text) {
                string nuevo_nombre = "ALTER TABLE " + tabla + "  DROP CHECK " + nombre_real;
                richTextBox2.Text = nuevo_nombre +";\n\n"+"ALTER TABLE " + tabla + " ADD CONSTRAINT " + textBox1.Text + " CHECK (" + checkviejo + ");";
            } else if (nombre_real != textBox1.Text || checkviejo != richTextBox1.Text) {
                string nuevo_nombre = "ALTER TABLE " + tabla + "  DROP CHECK " + nombre_real;
                richTextBox2.Text = nuevo_nombre + ";\n\n" + "ALTER TABLE " + tabla + " ADD CONSTRAINT " + textBox1.Text + " CHECK (" + richTextBox1.Text + ");";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox2.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Check modificado correctamente");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al modificar check \n" + ex.Message);
            }
        }
    }
}
