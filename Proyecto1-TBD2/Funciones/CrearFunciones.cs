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

namespace Proyecto1_TBD2.Funciones {
    public partial class CrearFunciones:Form {
        TreeView arbol;
        public CrearFunciones(TreeView _arbol) {
            InitializeComponent();
            arbol = _arbol;
        }

        private void CrearFunciones_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Text);
            try {
                connection.Open();
                DB2Command cmd = new DB2Command(richTextBox1.Text, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcion creada satisfactoriamente!");
                this.Hide();
            } catch (DB2Exception ex) {
                MessageBox.Show("Error al crear funcion\n" + ex.Message);
            }
            connection.Close();
        }
        public string obtenerQuery() {
            int cantidad = 0;
            string query = "CREATE OR REPLACE FUNCTION " + textBox1.Text + " (";
            foreach (DataGridViewRow row in contenido.Rows) {
                string modo = "", tipodato = "", nombre = "";
                if (cantidad < (contenido.Rows.Count - 1)) {
                    nombre += row.Cells [0].Value;
                    if (row.Cells [1].Value.ToString() != "NINGUNO") {
                        modo += row.Cells [1].Value;
                    }
                    tipodato += row.Cells [2].Value;
                    query += modo + " " + nombre + " " + tipodato + ",";
                }
                cantidad++;

            }
            query = query.Substring(0, query.Length - 1);
            query += ")\n P1:BEGIN \n \n END P1";


            return query;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.Text = obtenerQuery();
        }
    }
}
