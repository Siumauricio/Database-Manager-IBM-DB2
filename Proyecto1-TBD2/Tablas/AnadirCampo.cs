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

namespace Proyecto1_TBD2.Tablas {
    public partial class AnadirCampo:Form {
        TreeView arbol;
        string tabla;
        public AnadirCampo(TreeView _arbol,string _tabla) {
            InitializeComponent();
            arbol = _arbol;
            tabla = _tabla;
        }

        private void AnadirCampo_Load(object sender, EventArgs e) {
            dato.SelectedIndex = 0;
            escala.Text = "0";
            escala.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e) {
            PantallaPrincipal pn = new PantallaPrincipal();
            DB2Connection connection = pn.obtenerConexion(arbol.SelectedNode.Parent.Parent.Text);
            try {
                connection.Open();
                string query = "ALTER TABLE " + tabla + " ADD COLUMN " + nombre.Text +" ";
                string nullo = "";
                if ( checkBox2.Checked ) {
                    nullo += "NULL";
                } else {
                    nullo += "NOT NULL DEFAULT";
                }
                if (dato.Text == "VARCHAR") {
                    query += dato.Text + "(" + tamano.Text + ") "+ nullo;
                }
                if (dato.Text == "INT") {
                    query += dato.Text + " " + nullo;

                }if(dato.Text.Equals("DECIMAL")  || dato.Text.Equals("NUMERIC")) {
                    query += dato.Text + "(" + tamano.Text + "," + escala.Text + ") " + nullo;
                }

                DB2Command cmd = new DB2Command(query, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Campo Anadido correctamente");
                this.Hide();

            } catch (DB2Exception ex) {
                MessageBox.Show("Error al borrar campo\n" + ex.Message);

            }
            connection.Close();
        }

        private void dato_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (dato.Text == "VARCHAR") {
                    tamano.Enabled = true;
                    escala.Enabled = false;
                } else if (dato.Text == "INT") {
                    escala.Enabled = false;
                    tamano.Enabled = false;
                } else {
                    escala.Enabled = true;
                    tamano.Enabled = true;
                }
            } catch { }
          
        }
    }
}
